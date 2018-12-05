using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Runtime;

namespace Com.Facebook.Datasource {
	public partial class RetainingDataSourceSupplier {

		Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get() {
			return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
		}
	}
}
