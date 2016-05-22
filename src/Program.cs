using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using ChurnReports;
using System.Threading;
using System.Globalization;

//we need this because some namespaces did not exist in each version
//for example, StringCOllection moved from System.Collections to System.Collections.Specialized

using System.Collections.Specialized;
using System.Collections.Generic;

namespace LibCheck
{
    public partial class LibChk
    {

        #region Properties

        // ** Constants
        private const BindingFlags allBindingsLookup = BindingFlags.Public |
            BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

        // ** Fields	

        public static string vers = String.Format("{0:00}.{1:00}.{2}.{3:00}", new Object[] { Environment.Version.Major, Environment.Version.Minor, Environment.Version.Revision, Environment.Version.Build });

        static string en = Environment.NewLine; //included SOLELY to make the usage statement more readable

        static string usageOptions = "OPTIONS:" +
            en + "     -store [<assembly> | All | Full] <buildNumber>" +
            en + "     -file <folder>\\*.dll | -compare [<oldNumber> | current]  [<newNumber> | current ]" +
            en + "     [-split 4 | 10 | 15]   [-out <path>] [-nopause]" +
            en + "     [-full <path>] <options>";
        static string usage =
            en + "LibCheck <option>" +
            en +
            en + usageOptions +
            en +
            en + "-----------------------------------------------------------------------" +
            en + "     -store    Indicates that a set of store files should be created." +
            en + "               These can later be used to compare to other store files." +
            en + "               For a full comparison of all assemblies in the .NET framework," +
            en + "               specify All. For a full comparison of all dlls in a specific" +
            en + "               directory, specify full. Note that this will only work if" +
            en + "               the -full switch is also specified." +
            en +
            en + "     -compare  Indicates that a comparison should be made between two" +
            en + "               sets of store files (representing different builds)." +
            en + "               The Store and Compare options cannot both be specified." +
            en + "               The inputs for the process are presumed to exist in" +
            en + "               directories with the same names as those specified." +
            en + "               If current is specified, the compare will be done between the " +
            en + "               current assemblies in the version directory. " +
            en +
            en + "     [-split]  Allows you to specify whether files being split should be" +
            en + "               split into 4, 10, 15, or 20 files. The default is 10." +
            en +
            en + "     [-out]    Allows you to specify the location the reports are" +
            en + "               written to when comparing files. The default is" +
            en + "               <oldNumber>to<newNumber>" +
            en + "               E.g. -out 2505to2508          (Relative Path)" +
            en + "               E.g. -out c:\\reports          (Absolute Path)" +
            en +
            en + "     [-full]   Indicates that the path is a fully specified path to an " +
            en + "               assembly. If this switch is specified, please include " +
            en + "               the fully-specified path after the switch. Otherwise, the " +
            en + "               path is assumed to be in the same location as the SDK. " +
            en +
            en + "     [-owners] Indicates that the owners should be included in the output. " +
            en +
            en + "     [-bydll]  Indicates that the store should be done on a dll by dll basis" +
            en + "               rather than on a namespace by namespace basis. This is the default." +
            en +
            en + "     [-byspace]Indicates that the store should be done on a namespace by" +
            en + "               namespace basis, rather than on a dll by dll basis." +
            en +
            en + "     [-db]     Indicates that the information should be stored in a" +
            en + "               database, rather than serialized to file." +
            en +
            en + "	   [-gacload]Indicates that the files contained in gacload.txt should be loaded from" +
            en + "			     the GAC instead of from the version directory." +
            en +
            en + "     [-owners] Indicates that the owners should be included in the output. " +
            en +
            en + "     [-nochurn]Indicates that the estimated churn should not be shown. " +
            en +
            en + "     [-adds]   Indicates that the report should display only those things which. " +
            en + "               can be categorized as an added item, such as a new member, or" +
            en + "               type. " +
            en + "               NOTE: removing something from an old store will meet this category." +
            en +
            en + "     [-ser]    Indicates the store file should be created with serialization" +
            en + "               information included, to determine serialization compatibility or" +
            en + "               the comparison should be performed with this information included." +
            en +
            en + "     [-soap]   Indicates that the serialized information should be stored" +
            en + "               using the soap format. You cannnot specify soap and the DB" +
            en + "               option together. If you don't specify soap or db," +
            en + "               the information is serialized using the binary formatter." +
            en +
            en + "     [-struct]  Indicates structure layout field data should be created and saved " +
            en +
            en + "     [-structmethod]  Indicates structure layout method data should be created and saved " +
            en + "     				    Note that only one of -struct -structmethod or -ser may be used at one time." +
            en +
            en + "     [-file]   Indicates output should be stored as a controlled format, or" +
            en + "               retrieved from that format." +
            en +
            en + "     [-supp]   Suppresses output to the console." +
            en +
            en + "     [-header] Include information from the header.txt file in the summary report." +
            en +
            en + "     [-sumclr] Changed entries in the Summary report will appear in color." +
            en +
            en + "     [-noclr]  Changed entries in the Detail reports will not appear in color." +
            en +
            en + "     [-sumcho] Indicates that only namespaces that have changed should be listed" +
            en + "               in the summary page." +
            en +
            en + "     [-alldet] Indicates that the details for changes should all be placed in one," +
            en + "               big details page, rather than being split up." +
            en + "               When you select this option, the details links are placed at the" +
            en + "               top and bottom of the page." +
            en +
            en + "     [-nolink] Indicates no links to details should be on the summary page." +
            en + "               You can only specify this option with the -alldet switch." +
            en +
            en + "     [-htm]    Indicates that the summary and detail files should have the" +
            en + "               extension 'htm', as opposed to the default, 'html'." +
            en +
            en + "     [-com <x>]Generate COM compatibility reports for any assemblies found," +
            en + "               when doing a comparison. If <x> is replaced with a t (default)" +
            en + "               the report is generated: if replaced with an f, it is not." +
            en + "               Replacing <x> with the word 'only' generates the com report only." +
            en + "-----------------------------------------------------------------------" +
            en +
            en + "NOTES: Either -store, or -compare must be specified." +
            en +
            en + "       If you are storing a file (-store), the build number specified" +
            en + "       indicates the location the serialization file will be" +
            en + "       written to. Also note that in order to be successfully stored," +
            en + "       classes MUST be in a namespace. Classes not within a namespace" +
            en + "       will not cause an exception, but will not be captured by the tool." +
            en +
            en + "-----------------------------------------------------------------------";

        //static XmlReport xmlReport;
#if DOREPORTS
        public static StreamWriter errorWriter = null;
        public static StreamWriter reportWriter = null;
#endif

        static ChurnReport summary = null;	// Churn Report
        static UnifiedReport unified = null;	// Unified Reports - one per assembly.

        static bool _runStore = false;
        static string _assembly = null;
        static string _buildNumber = null;
        static bool _runCompare = false;
        static CurrentCompare _runCurrentCompare = CurrentCompare.Specific;
        static string _oldBuild = null;
        static string _newBuild = null;

        static string newVersion = "";
        static string oldVersion = "";

        enum CurrentCompare { Specific = 0, Old = 1, New = 2 };

        static string _codebase = null;
        static int _dbug = 0;
        public static bool nopause = false;

        // THIS IS THE STORE FOR NAMESPACES!
        static Hashtable htNamespaces = new Hashtable();
        static Hashtable ObsoleteHT = new Hashtable();

        static int numSplits = 0;

        public static String outputLoc = "";

        static Hashtable htGACdlls = null;
        static ArrayList alSplitF = null;
        static ArrayList alSplitNamespaces = null;
        //static ArrayList alIntfcAdds = null;
        //static ArrayList comDlls = null;
        static Hashtable htRanges = null;
        static StreamWriter AddsFile = null;

        static StringCollection splitRanges = new StringCollection();

        static string fileFound = "";
        static String fileDir = "";
        static int splitFound = 0;

        static bool useHTM = false;
        static bool sumAll = true; //DEFAULT
        static bool allDetails = true; // false;
        static bool noLink = false;
        static bool addsOnly = false; 
        static bool sumColor = false;
        static bool suppress = true; 
        static bool byDll = false;   // true; //DEFAULT
        static bool fullSpec = true; // false;

        static bool showChurn = true; //DEFAULT
        static bool addSer = false;
        static bool storeDB = false;
        static bool storeSoap = false;
        static bool incHeader = true; // false; 
        static bool makeComReport = true;
        static bool comOnly = false;
        static bool GACload = false;

        //just for verification testing
        //robvi
        static Hashtable ht = new Hashtable();
        static bool addStruct = false;
        static bool addStructMethod = false; 
        public static StreamWriter obsoletewriter; 

        // ** Properties
        public static string OldVer { get { return _oldBuild; } }
        public static string NewVer { get { return _newBuild; } }

        #endregion

        public static List<ClassInfo> ClassList;
        public static List<Assembly> AsmList;
        public static Exception LastError { get; set; }
        // ** Methods
        public static void Main(String[] args)
        {
            #region Parse args

            IsPrepared = false;
            Console.WriteLine("start time = " + DateTime.Now);

            try
            {
                if (args.Length >= 1 && args[0] != "-debug")
                    obsoletewriter = File.CreateText("obsolete.txt");
            } catch (Exception ex) { LastError = ex; }
            long startTicks = DateTime.Now.Ticks;

            //ALWAYS FORCE THE CULTURE TO en-US
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            StringBuilder codebase = new StringBuilder(Assembly.Load("mscorlib").CodeBase);

            Console.WriteLine("Codebase=" + codebase);

            //WEIRD CHANGE REQUIRED, CAME IN AT BUILD 2701
            if (codebase.ToString().IndexOf("///") > -1)
                codebase = codebase.Replace("file:///", "");
            else
                codebase = codebase.Replace("file://", "");

            codebase = codebase.Replace("/mscorlib.dll", "");

            _codebase = codebase.Replace("/", Path.DirectorySeparatorChar.ToString()).ToString();

            bool goodToGo = false;
            Exception err = null;
            try
            {
                goodToGo = ParseArgs(args);
            }
            catch (ArgumentException e)
            {
                LastError = e;
                err = e;
                // if (!suppress)

                {
                    foreach (string item in Environment.GetCommandLineArgs())
                        Console.Write(item + " ");
                    Console.Write(Environment.NewLine);

                    Console.WriteLine(en + e.Message);
                    Console.WriteLine(usageOptions);
                }
            }
            catch (Exception e)
            {
                LastError = e;
                err = e;

                foreach (string item in Environment.GetCommandLineArgs())
                    Console.Write(item + " ");
                Console.Write(Environment.NewLine);

                // if (!suppress)
                {
                    Console.WriteLine(en + e.ToString());
                    Console.WriteLine(usageOptions);
                }
            }
            
            #endregion
            if (!goodToGo)
                return;

            //find out WHICH files are to be split up
            //first thing is to check if this is a split file
            Prepare();

            if (_runStore)
            {
                if (!PassDirectory())
                    return;

                if (_assembly.ToLower() == "full" || _assembly.Contains("*"))
                {
                    var ignFile = Path.GetFullPath("reffiles\\ignorefiles.txt");
                    ArrayList ignoreFiles = OpenFileList(ignFile);

                    _assembly = Path.GetFileNameWithoutExtension(_assembly);
                    string filter = "*.dll";
                    if (_assembly.Contains("*"))
                    {
                        filter = _assembly + ".dll";
                        _assembly = "full";
                    }

                    ClassInfo.Reset();

                    if (!Directory.Exists(fileDir))
                    { 
                        Console.WriteLine("No directory " + fileDir);
                        return;
                    }

                    DirectoryInfo di = new DirectoryInfo(fileDir);

                    foreach (FileInfo f in di.GetFiles(filter))
                    {
                        Console.WriteLine(Path.Combine(fileDir, f.Name));

                        if (ignoreFiles.Contains(f.Name))
                            continue;

                        MakeStoreFiles(f.Name);
                    }
                }
                else
                {
                    ClassInfo.Reset();
                    MakeStoreFiles(_assembly);
                }
            }

            ClassInfo.Reset();
            // PostProcess();

            if (!suppress && obsoletewriter != null)
                obsoletewriter.Close();
            Console.WriteLine("\r\nLibCheck Done.\r\n");

            long endTicks = DateTime.Now.Ticks;
            TimeSpan duration = new TimeSpan(endTicks - startTicks);
            Console.WriteLine("End Time = " + DateTime.Now);
            Console.WriteLine("\r\nTotal Time = {0}\r\n", duration);

            //CLOSE THE RF
            //if (rf != null)
            //    rf.Close();

            if (!nopause)
                 Console.ReadLine();
        }

        #region Prepare methods

        public static void Prepare()
        { 
            alSplitF = OpenFileList("reffiles\\splitfiles.txt");
            alSplitNamespaces = OpenFileList("reffiles\\splitNamespaces.txt");
            htGACdlls = OpenGACList("reffiles\\gacload.txt");
            GetSplitRanges();

            ClassList = new List<ClassInfo>();
            AsmList = new List<Assembly>();

            IsPrepared = true;
        }

        public static bool IsPrepared { get; set; }

        static void PostProcess()
        {
            if (_runCompare)
            {

                //if (makeComReport)
                //    // make the Com arraylist...
                //    //this is ALL dlls in the specified comparison location...
                //    MakeComList();

                if (comOnly == false)
                {
                    MakeReports();

                    if (allDetails)
                        unified.Close(useHTM);
                }

                if (makeComReport)
                {
                    //MakeComCompat();
                }
            }

            if (_runCurrentCompare > CurrentCompare.Specific)
            {
                MakeCurrentReport();

                if (allDetails)
                    unified.Close(useHTM);
            }

        }

        static bool PassDirectory()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() +
                Path.DirectorySeparatorChar + _buildNumber))
            {
                if (!suppress)
                {
                    Console.WriteLine(Environment.NewLine + "The following required directory " +
                        "does not exist.");

                    Console.WriteLine(Directory.GetCurrentDirectory() +
                        Path.DirectorySeparatorChar + _buildNumber);

                    Console.WriteLine("It will be created." + Environment.NewLine);

                }
                //CREATE the directory...
                try
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() +
                        Path.DirectorySeparatorChar + _buildNumber);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occurred trying to create the directory:");
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }

            return true;
        }
        
        // Parse the argument array
        static bool ParseArgs(string[] args)
        {
            _runStore = false;
            _runCompare = false;
            outputLoc = Path.GetFullPath(Environment.CurrentDirectory);

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i].ToLower();

                if (arg == "-debug")
                {
                    Console.WriteLine("Press any key");
                    Console.ReadLine();     // for debugger attach
                    suppress = false;
                    continue;
                }

                if (arg == "-store")
                {
                    if (_runStore)
                        throw new ArgumentException("Only specifiy the -Store option once.");
                    if (args.Length <= i + 2)
                        throw new ArgumentException("Too few arguments for the -Store option.");

                    _runStore = true;
                    _assembly = args[++i];
                    _buildNumber = args[++i];
                }
                else if (arg == "-nopause")
                {
                    nopause = true;
                }
                else if (arg == "-compare")
                {
                    if (_runCompare)
                        throw new ArgumentException("Only specifiy the -Compare option once.");
                    if (args.Length <= i + 2)
                        throw new ArgumentException("Too few arguments for the -Compare option.");
                    _oldBuild = args[++i];
                    _newBuild = args[++i];

                    if (_oldBuild.ToLower() == "current")
                    {
                        _runCurrentCompare = CurrentCompare.Old;
                        //TEMP: current compare can ONLY be done by dll
                        byDll = true;
                        _runCompare = false;
                    }

                    if (_newBuild.ToLower() == "current")
                    {
                        _runCurrentCompare = CurrentCompare.New;
                        //TEMP: current compare can ONLY be done by dll
                        byDll = true;
                        _runCompare = false;
                    }
                    else
                    {
                        if (_runCurrentCompare == CurrentCompare.Specific)
                            _runCompare = true;
                    }
                }
                else if (arg == "/?" || arg == "-?")
                {
                    Console.Write(usage);
                    return false;
                }
                else if (arg.StartsWith("-dbug"))
                {
                    _dbug = (arg.IndexOf(':') > 0) ? Convert.ToInt32(arg.Split(new char[] { ':' })[1]) : 1;
                }
                else if (arg.ToLower().StartsWith("-out"))
                {
                    outputLoc = args[i + 1];
                    if (!outputLoc.EndsWith(@"\"))
                        outputLoc += @"\";
                    i++;
                }
                //else if (arg.ToLower().StartsWith("-owners"))
                //{
                //    showOwners = true;
                //}
                else if (arg.ToLower().StartsWith("-nochurn"))
                {
                    showChurn = false;
                }
                else if (arg.ToLower().StartsWith("-adds"))
                {
                    addsOnly = true;
                }
                else if (arg.ToLower().StartsWith("-full"))
                {
                    fullSpec = true;
                    fileDir = args[i + 1];
                    i++;
                }
                else if (arg.ToLower().StartsWith("-file"))
                {
                    fullSpec = false;
                    _runStore = true;
                    _assembly = args[++i];
                    fileDir = Path.GetDirectoryName(_assembly);
                }
                else if (arg.ToLower().StartsWith("-gacload"))
                {
                    GACload = true;
                }
                else if (arg.ToLower().StartsWith("-ser"))
                {
                    addSer = true;
                }
                else if (arg.ToLower().StartsWith("-structmethod"))
                {
                    addStructMethod = true;
                }
                else if (arg.ToLower().StartsWith("-struct"))
                {
                    addStruct = true;
                }

                else if (arg.ToLower().StartsWith("-bydll"))
                {
                    byDll = true;
                }
                else if (arg.ToLower().StartsWith("-byspace"))
                {
                    byDll = false;
                }
                //else if (arg.ToLower().StartsWith("-db"))
                //{
                //    storeDB = true;
                //    storeAsFile = false;
                //}
                //else if (arg.ToLower().StartsWith("-soap"))
                //{
                //    storeSoap = true;
                //    storeAsFile = false;
                //}
                //else if (arg.ToLower().StartsWith("-file"))
                //{
                //    storeAsFile = true;
                //}
                else if (arg.ToLower().StartsWith("-supp"))
                {
                    suppress = false; // true;
                }
                else if (arg.ToLower().StartsWith("-header"))
                {
                    incHeader = true;
                }
                //else if (arg.ToLower().StartsWith("-noclr"))
                //{
                //    noColor = true;
                //}
                else if (arg.ToLower().StartsWith("-sumclr"))
                {
                    sumColor = true;
                }
                else if (arg.ToLower().StartsWith("-sumcho"))
                {
                    sumAll = false;
                }
                else if (arg.ToLower().StartsWith("-alldet"))
                {
                    allDetails = true;
                }
                else if (arg.ToLower().StartsWith("-nolink"))
                {
                    noLink = true;
                }
                else if (arg.ToLower().StartsWith("-htm"))
                {
                    useHTM = true;
                }
                else if (arg.ToLower().StartsWith("-com"))
                {
                    if (_runCompare == false)
                    {
                        throw new ArgumentException("Ensure that you specify this is a comparison, before specifying the COM report switch.");

                    }

                    i += 1;
                    if (i >= args.Length)
                    {
                        throw new ArgumentException("The -com switch must be followed by 'f', 't', or 'only'");
                    }

                    if (args[i].ToLower().Equals("f"))
                    {
                        makeComReport = false;
                    }
                    else if (args[i].ToLower().Equals("t"))
                    {
                        makeComReport = true;
                    }
                    else if (args[i].ToLower().Equals("only"))
                    {
                        makeComReport = true;
                        comOnly = true;
                    }
                    else
                    {
                        throw new ArgumentException("The -com switch must " +
                            "be followed by 'f', 't', or 'only'");
                    }

                }
                else if (arg.ToLower().StartsWith("-split"))
                {
                    try
                    {
                        numSplits = Convert.ToInt32(args[i + 1]);
                    }
                    catch (Exception)
                    {
                        numSplits = 4; // default
                        //throw new ArgumentException(
                        //    "The -split option must be followed by either the number 4, 10, or 15.");
                    }

                    if (numSplits != 4 && numSplits != 10 && numSplits != 15
                        && numSplits != 20 && numSplits != 30)
                        throw new ArgumentException(
                            "The -split option must be followed by either the number 4, 10, or 15.");
                    i++;
                }
                else
                    //var dir = Path.GetDirectoryName(arg);
                    //if (d)
                    throw new ArgumentException("Unknown command line parameter '" + arg + "'");
            }

            if (args.Length == 0 || !(_runStore || _runCompare || _runCurrentCompare > (CurrentCompare)0))
                throw new ArgumentException("Please use one or more of the available options.");

            //if ((storeDB && storeSoap) || (storeAsFile && (storeDB || storeSoap)))
            //    storeAsFile = true;
            //throw new ArgumentException("You cannot specify to store by DB and Soap Format, " +
            //    "or by db or soap, and by file.");

            if (noLink && !allDetails)
                throw new ArgumentException("You cannot specify the -nolink switch without also " + "specifying the -alldetails switch.");

            if (_runStore && _assembly.ToLower() == "full" && fullSpec == false)
                throw new ArgumentException("You cannot specify the store to be full, without also " + "specifying the -full switch.");

            if (numSplits == 0)
                numSplits = 10;

            return true;
        } // end ParseArgs()

        static ArrayList OpenFileList(String filetoopen)
        {

            FileInfo f = new FileInfo(filetoopen);

            StreamReader sr = new StreamReader(f.OpenRead());

            ArrayList alSplitFiles = new ArrayList();

            while (sr.Peek() > -1)
            {
                alSplitFiles.Add(sr.ReadLine());
            }

            sr.Close();

            return alSplitFiles;
        }

        //ROBVI
        //Reads in the textfile gacload.txt and loads these assemblies from the GAC into a Hashtable
        //the hashtable is used to translate between .dll names and the names stored in the GAC.

        static Hashtable OpenGACList(String filetoopen)
        {
            FileInfo f = new FileInfo(filetoopen);
            StreamReader sr = new StreamReader(f.OpenRead());
            Hashtable dllmap = new Hashtable();

            while (sr.Peek() > -1)
            {
                String full = sr.ReadLine();
                String key = full.Substring(0, full.IndexOf(":"));
                key = key.ToLower();
                String val = full.Substring(full.IndexOf(":") + 1);
                dllmap.Add(key, val);
            }
            return (dllmap);
        }



        // allows personal control of the splitting of dlls
        static void GetSplitRanges()
        {

            int found = -1;
            string tempEntry = "";

            StreamReader sr = new StreamReader("reffiles\\splitRanges.txt");

            htRanges = new Hashtable();

            while (sr.Peek() > -1)
            {
                string temp = sr.ReadLine().Trim().ToLower();

                found = temp.IndexOf(",");

                if (found < 0) //SHOULD NEVER HAPPEN
                    continue; //ignore this item
                else
                {

                    if (temp.Substring(0, found).Trim() == numSplits.ToString())
                    {
                        //organize by the next entry...
                        string sub = temp.Substring(found + 1);

                        int innerItem = sub.IndexOf(",");

                        if (innerItem < 0) //SHOULD NEVER HAPPEN
                            continue; //ignore this item
                        else
                        {
                            string entry = sub.Substring(0, innerItem).Trim().ToLower();

                            if (tempEntry != entry)
                            {
                                if (splitRanges != null)
                                    htRanges[tempEntry] = splitRanges;

                                splitRanges = new StringCollection();
                                tempEntry = entry;
                            }

                            splitRanges.Add(sub.Substring(innerItem + 1));
                        }
                    }
                }

            }

            //NOTE: the LAST stringcollection will not ahve been added in all probability
            //even if it has, doing it again won't hurt
            if (splitRanges != null)
                htRanges[tempEntry] = splitRanges;
        }

        //this ASSUMES that a range for "all" always exists
        static StringCollection GetCorrectSplit(Assembly a)
        {

            if (htRanges.Contains(Path.GetFileName(a.CodeBase).ToLower()))
                return (StringCollection)htRanges[Path.GetFileName(a.CodeBase).ToLower()];
            else
                return (StringCollection)htRanges["all"];
        }

        #endregion

    } // end LibChk
}
