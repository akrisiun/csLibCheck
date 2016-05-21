using System;
using System.Reflection;
using System.Collections;

namespace SigHelper {
	
	public class CsTypeInfo: GenTypeInfo {
		
		// ** Constructors
		public CsTypeInfo(Type type): base(type, TypeFormats.Default, false) {}
		public CsTypeInfo(Type type, TypeFormats format): base(type, format, false) {}
		public CsTypeInfo(Type type, bool flag): base(type, TypeFormats.Default, flag) {}
		public CsTypeInfo(Type type, TypeFormats format, bool flag): base(type, format, flag) {
			if (_dbug) Console.Write(" CsTypeInfo: Construction of type " + type.FullName + " completed.");
		}
		public CsTypeInfo(CsTypeInfo ti): base((GenTypeInfo)ti) {}

		// ** Properties
		public override string Sig { get { return ToHtml(TypeFormats.Default); } }

		// ** Overriden Methods
		public new static string ToString(Type t) { return (new CsTypeInfo(t)).ToString(); }
		public new static string ToString(Type t, TypeFormats f) { return (new CsTypeInfo(t, f)).ToString(); }
		public override string ToString() { return ToString(_format); }

		public override string ToString(TypeFormats format) {
			string result = (IncludeInheritFlag(format) && _inherited) ? InheritedString() : String.Empty;
			
			if (ShortSig(format)) 
				return result + ((_namespace != String.Empty) ? _namespace + "." + _name : _name);

            bool IsStatic = false;
            if (_reflectedtype != null && _reflectedtype.IsSealed)
            {
            }
            else if (IsAbstract && IsSealed && this._basetype == typeof(Object))
            {
                IsStatic = true;
            }

            string temp = String.Empty;
			result += (NamespaceSeparate(format) && _namespace != String.Empty) ? result += _namespace + ": " : "";
			result += ((temp = ToString(_access)) != String.Empty) ? temp + " " : "";

            temp = ToString(_modifiers);
            if (IsStatic && temp == "abstract sealed")
                temp = "static";
            if (temp != String.Empty)
                result += temp + " ";

            temp = ToString(_typekind);
            if (temp.Contains("`") && _reflectedtype != null)
            {
                // <T> type
                var ctor2 = _reflectedtype.GetConstructors();
            }

            result += temp + " ";
			result += (!NamespaceSeparate(format) && _namespace != String.Empty) ? _namespace + "." : "";

			result += _name;

            if (_basetype != typeof(Object))
                temp = ToString(_basetype, _primaryinterfaces);
            else
                temp = ToString(null, _primaryinterfaces);

            result += (IncludeBaseClass(format) && temp != String.Empty) ? " : " + temp : String.Empty;
			return result;
		}

		// TODO: add more specific HTML formatting. Perhaps use spans and classes for a style sheet to interact with.
		public new static string ToHtml(Type t) { return (new CsTypeInfo(t)).ToHtml(); }
		public new static string ToHtml(Type t, TypeFormats f) { return (new CsTypeInfo(t, f)).ToHtml(); }
		public override string ToHtml() { return ToHtml(_format); }
		public override string ToHtml(TypeFormats format) {
			if (_nested)
				return NestedToHtml(format);

			string result = String.Empty;

			if ((format & TypeFormats.ShortSig) != 0)
				return "<b>" + ((_namespace != String.Empty) ? _namespace + "." + _name : _name) + "</b>";
			
			string temp = String.Empty;
			if (format == TypeFormats.NamespaceSeparate && _namespace != String.Empty)
				result += "<b>" + _namespace + "</b>: ";

			result += ((temp = ToHtml(_access)) != String.Empty) ? temp + " " : "";
			result += ((temp = ToHtml(_modifiers)) != String.Empty) ? temp + " " : "";
			result += ToHtml(_typekind) + " <b><span title=\"" + ToHtml(_basetype, _primaryinterfaces, _secondaryinterfaces) + "\">";
			result += ((!NamespaceSeparate(format) && _namespace != String.Empty) ? _namespace + "." : "") + _name + "</span></b>";
			return result;
		}

		// creates the CS style HTML signatures for Nested Types
		public string NestedToHtml(TypeFormats format) {
			string temp = String.Empty;

			string result = "Nested Type" + ((_inherited) ? " " + InheritedHtml() : "") + ": ";

			result += ((temp = ToHtml(_access)) != String.Empty) ? temp + " " : "";
			result += ((temp = ToHtml(_modifiers)) != String.Empty) ? temp + " " : "";


//			result += ToHtml(_typekind) + " <b><span title=\"" + ToHtml(_basetype, _primaryinterfaces, //_secondaryinterfaces) + "\">";
//			result += _name + "</span></b>";
//result += "<br><table><tr><td><font size=2><b>" + ToHtml(_basetype, _primaryinterfaces, _secondaryinterfaces) + //"</b></font></td></tr></table>";

			result += ToHtml(_typekind) + " <b><span title=\"" + ToHtml(_basetype, _primaryinterfaces, _secondaryinterfaces) + "\">";

			result += _name + "</span></b>";


//prin
			string val = "<br>";

			if (ToHtml(_typekind).ToLower() == "enum") {
				//ok, write out the entries AND values!
				Type thisType = _reflectedtype.GetNestedType(_namespace);

				string[] names = Enum.GetNames(thisType);

				for (int i = 0;i<names.Length;i++) {
					if (i!=0)
						val += ", <br>";
//JUST NEED TO ADD SOME NON-BREAKING SPACES!!!
					for (int j=0;j<20;j++)
						val += "&nbsp";

					val += names[i] + " = " + 
						((Enum)Enum.Parse(thisType,names[i])).ToString("d");
				}

				val += "<br>";
			}

			result += val;


			return result;
		}

		public new static string ToString(AccessModifiers access) { 
			return SigHelper.CsTranslate(Enum.GetName(typeof(AccessModifiers), access));
		}
		
		public new static string ToString(TypeModifiers [] modifiers) {
			string result = String.Empty;
			foreach (TypeModifiers tm in modifiers) {
				result += SigHelper.CsTranslate(Enum.GetName(typeof(TypeModifiers), tm)) + " ";
			}

			return result.TrimEnd(new Char[] {' '});
		}
		
		public new static string ToString(TypeKinds kind) {
			return SigHelper.CsTranslate(Enum.GetName(typeof(TypeKinds), kind));
		}

		// Creates the base class and interfaces pop up text for the plain text signature
		public static string ToString(Type basetype, Type[] primary) {
			string result = String.Empty;
			
			if (basetype != null && basetype != typeof(Object))
                result += ParseInterface(basetype); // .FullName;

			if (basetype != null && primary.Length > 0)
				result += " ";

			for (int i = 0; i < primary.Length; i++)
				result += ((i > 0) ? ", " : "") + ParseInterface(primary[i]);

			return result;
		}

        public static string WithNS(Type basetype)
        {
            return basetype.Namespace + "."
                    + (basetype.Name.EndsWith("`1") || basetype.Name.EndsWith("`2") || basetype.Name.EndsWith("`3") 
                       || basetype.Name.EndsWith("`4") ?  
                       basetype.Name.Substring(0, basetype.Name.Length - 2) :
                       basetype.Name);
        }

        public static string ParseInterface(Type inf)
        {
            if (inf.IsGenericType)
            {
                var under = inf.UnderlyingSystemType;
                string temp = WithNS(under) + "<";
                bool isFirst = true;
                foreach (var arg in inf.GenericTypeArguments)
                {
                    if (isFirst) isFirst = false;
                    else temp += ",";

                    temp += WithNS(arg);
                }

                if (isFirst && inf.ContainsGenericParameters && inf is System.Reflection.TypeInfo)
                {
                    var inf2 = inf as System.Reflection.TypeInfo;
                    foreach (var it in inf2.GenericTypeParameters)
                    {
                        if (isFirst) isFirst = false;
                        else temp += ",";

                        temp += it.Name;
                    }
                }
                else if (isFirst)
                    temp += "Object";

                int pos = temp.IndexOf("`");
                if (!isFirst && pos > 2)
                {
                    var temp2 = temp.Substring(0, pos) + temp.Substring(pos + 2, temp.Length - pos - 2);
                    temp = temp2;
                }

                temp += ">";
                return temp;
            }

            if (inf.IsAnsiClass && !inf.IsArray)
            {
                if (inf.Name.StartsWith("ArraySegment`")
                    && inf.FullName.Contains("[[System.Byte")) // 1 &)
                {
                    return "ArraySegment<byte>";
                }
            }

            return WithNS(inf);
        }

		// Creates the base class and interfaces pop up text for the HTML signature
		public static string ToHtml(Type basetype, Type[] primary, Type[] secondary) {
			string result = "Base Type: " + ((basetype != null) ? basetype.FullName : "none");

			if (primary.Length + secondary.Length == 0)
				return result;

			result += "; Interfaces: ";
			for (int i = 0; i < primary.Length; i++)
				result += ((i > 0) ? ", " : "") + primary[i].FullName;

			if (primary.Length > 0 && secondary.Length > 0)
				result += "; ";

			for (int i = 0; i < secondary.Length; i++)
				result += ((i > 0) ? ", " : "") + secondary[i].FullName;

			return result;
		}

		public new static string ToHtml(AccessModifiers access) {

//MODIFIED, mod0083
//#if BETA1
			string result = SigHelper.CsTranslate(Enum.GetName(typeof(AccessModifiers), access));
//#else
//			string result = SigHelper.CsTranslate(((Enum)access).ToString());
//#endif

			if (result == "Unassigned" || result == "NoModifier")
				result = "<i>" + result + "</i>";
			return result;
		}
		public new static string ToHtml(TypeModifiers [] modifiers) {
			string result = String.Empty;
			foreach (TypeModifiers tm in modifiers) {

//MODIFIED, mod0084
//#if BETA1
				result += (tm == TypeModifiers.Unknown) ? "<i>UnknownModifier</i> " : 
				SigHelper.CsTranslate(Enum.GetName(typeof(TypeModifiers), tm)) + " ";

//#else
//				result += (tm == TypeModifiers.Unknown) ? "<i>UnknownModifier</i> " : 
//				SigHelper.CsTranslate(((Enum)tm).ToString()) + " ";
//#endif
			}
			return result.TrimEnd(new Char[] {' '});
		}
		
		public new static string ToHtml(TypeKinds kind) {

//MODIFIED, mod0085
//#if BETA1
			string result = SigHelper.CsTranslate(Enum.GetName(typeof(TypeKinds), kind));
//#else
//			string result = SigHelper.CsTranslate(((Enum)kind).ToString());
//#endif

			if (result == "Unassigned" || result == "Unknown")
				result = "<i>" + result + "</i>";
			return result;
		}
	}
}