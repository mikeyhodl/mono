//
// System.Reflection/ConstructorInfo.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System;
using System.Reflection;
using System.Globalization;

namespace System.Reflection {
	public abstract class ConstructorInfo : MethodBase {
		public static readonly string ConstructorName = ".ctor";
		public static readonly string TypeConstructorName = ".cctor";

		protected ConstructorInfo() {
		}
		
		public override MemberTypes MemberType {
			get {return MemberTypes.Constructor;}
		}

		public object Invoke (object[] parameters)
		{
			//FIXME
			return null;
		}

		public abstract object Invoke( BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	}
}
