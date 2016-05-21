using System;
using System.Collections;
using System.Reflection;

namespace SigHelper {

	public class CsMethodInfo : GenMethodInfo {

		//** Fields
		//** Ctors
		public CsMethodInfo (MethodInfo method) : base (method) {}
		public CsMethodInfo (GenMethodInfo mi) : base ((GenMethodInfo)mi) {}

		//** Properties
		public override string Sig { get { return ToHtml(); } }

		//** Methods
		public new static string ToString(MethodInfo method)
        { return (new CsMethodInfo(method)).ToString(); }

		public override string ToString() {
			string temp;
			string result = "    ";
                       //. ToString(_methodkind);													// MemberType

			result += ((temp = ToString(_access)) != String.Empty) ? temp + " " : String.Empty;		// Scope
			result += ((temp = ToString(_modifiers)) != String.Empty) ? temp + " " : String.Empty;	// Modifiers

            result += (_inherited) ? "override " // + InheritedString() 
                    : "";

            if (_returntype.FullName != null)
            {
                var intName = CsTypeInfo.ParseInterface(_returntype);
                result += SigHelper.CsParse(intName) + " ";                                         // Type
            }
			result += _name;																		// Name

            result += ToString(_parameters, _varargs, this);  						
                                                                                                    // Parameters
            if (this._reflectedtype.IsInterface || !this._reflectedtype.IsClass)
                result += ";";
            else 
                result += result.Contains(" void ") ? " {}" :
                          " { throw new NotImplementedException(); }";

            //	result += " - " + String.Format("0x{0:x}", _attributes);
			return result;
		}

		public static string ToHtml(MethodInfo method) { return (new CsMethodInfo(method)).ToHtml(); }
		
        public new string ToHtml() {
			string temp;
			string result = ToHtml(_methodkind);																	// MemberType
			result += (_inherited) ? " " + InheritedHtml() + ": " : ": ";											// Inherited flag
			result += ((temp = SigHelper.CsTranslate(ToHtml(_access))) != String.Empty) ? temp + " " : String.Empty;	// Scope
			result += ((temp = ToHtml(_modifiers)) != String.Empty) ? temp + " " : String.Empty;					// Modifiers
			result += "<span title=\"" + _returntype.Namespace + "\">";												// Type
			result += SigHelper.CsParse(_returntype.Name) + "</span> ";
			result += "<b>" + _name + "</b>";																		// Name
			result += " " + ToHtml(_parameters, _varargs);															// Parameters
			return result;
		}

		//** Helper Methods
		protected new static string ToString(MethodKinds kind) {
			if ((kind & MethodKinds.MethodMask) != 0)
				return "Method";
			else
				return "Unknown Method Type";
		}
		protected new static string ToHtml(MethodKinds kind) {
			if ((kind & MethodKinds.MethodMask) != 0)
				return "Method";
			else
				return "<i>Unknown Method Type</i>";
		}

		protected new static string ToString(AccessModifiers access) {
			switch(access) {
			case AccessModifiers.na:
				return String.Empty;
			case AccessModifiers.Unknown:
			case AccessModifiers.Unassigned:
				return "UnknownAccess";
			default:
//MODIFIED, mod0072
//#if BETA1
				return SigHelper.CsTranslate(Enum.GetName(typeof(AccessModifiers), access));
//#else
//				return SigHelper.CsTranslate(((Enum)access).ToString());
//#endif
			}
		}
		protected new static string ToHtml(AccessModifiers access) {
			switch(access) {
			case AccessModifiers.na:
				return String.Empty;
			case AccessModifiers.Unknown:
			case AccessModifiers.Unassigned:
				return "<i>UnknownAccess</i>";
			default:
//MODIFIED, mod0073
//#if BETA1
				return SigHelper.CsTranslate(Enum.GetName(typeof(AccessModifiers), access));
//#else
//				return SigHelper.CsTranslate(((Enum)access).ToString());
//#endif
			}
		}

		protected new static string ToString(MethodModifiers [] modifiers) {
			string result = String.Empty;

			for(int i = 0; i < modifiers.Length; i++) {

//MODIFIED, mod0074
//#if BETA1
				result += ((i > 0) ? " " : "") + SigHelper.CsTranslate(Enum.GetName(typeof(MethodModifiers), modifiers[i]));
//#else
//				result += ((i > 0) ? " " : "") + SigHelper.CsTranslate(((Enum)modifiers[i]).ToString());
//#endif
			}

			return result;
		}
		protected new static string ToHtml(MethodModifiers [] modifiers) { return ToString(modifiers); }

		protected new static string ToString(GenParameterInfo [] parameters, bool varargs, GenMethodInfo methInfo = null) {
			string result = "(";
            Type itemType = methInfo == null ? null : methInfo.DeclaringType;
            bool isExtension = false;
            if (itemType != null && itemType.IsAbstract)
            {
                var hasExtension = itemType.GetCustomAttribute<System.Runtime.CompilerServices.ExtensionAttribute>();
                isExtension = hasExtension != null;
            }

            for (int i = 0; i < parameters.Length; i++)
            {
                var info = new CsParameterInfo(parameters[i]);
                var infoStr = info.ToString();
                if (infoStr.IndexOf('`') >= 0)
                {
                    var type = parameters[i].Type;
                    if (type.HasElementType) // && type.ContainsGenericParameters)
                    {
                        var inf2 = type as System.Reflection.TypeInfo;
                        var args = inf2.GenericTypeArguments;  // type.GenericParameterAttributes;
                        if (args.Length > 0)
                        {
                            //var isGen = inf2.IsGenericParameter;
                            //var isGen2 = inf2.IsGenericType;
                            //var isGen3 = inf2.IsGenericTypeDefinition;

                            var info2 = CsTypeInfo.ParseInterface(type);
                            infoStr = info2.ToString();
                        }
                        
                    }
                    if (infoStr.Contains("`1"))
                    {
                        var fullT = type.FullName;
                        if (fullT.Contains("1[[System.String"))
                            infoStr = infoStr.Replace("`1", "<string>");  // hardcoded :-)
                        else 
                            infoStr = infoStr.Replace("`1", "<object>");  // TODO
                    }
                    else if (infoStr.Contains("`2"))
                    {
                        infoStr = infoStr.Replace("`2", "<object,object>");  // TODO
                    }
                    else if (infoStr.Contains("`3"))
                    {
                        infoStr = infoStr.Replace("`3", "<object,object,object>");  // TODO
                    }
                }

                if (isExtension && i == 0)
                    result += "this ";

                result += ((i > 0) ? ", " : String.Empty) + infoStr;
                
            }
			if (varargs)
				result += ", __arglist";
			result += ")";
			return result;
		}
		protected new static string ToHtml(GenParameterInfo [] parameters, bool varargs) {

			string result = "(";
			for(int i = 0; i < parameters.Length; i++)
				result += ((i > 0) ? ", " : String.Empty) + (new CsParameterInfo(parameters[i])).ToHtml();
			if (varargs)
				result += ", __arglist";
			result += ")";
			return result;
		}
	}
}