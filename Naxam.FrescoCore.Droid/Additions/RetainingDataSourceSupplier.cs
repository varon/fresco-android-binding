using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Runtime;

namespace Com.Facebook.Datasource {
	public partial class RetainingDataSourceSupplier : global::Java.Lang.Object, global::Com.Facebook.Common.Internal.ISupplier {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.datasource']/class[@name='RetainingDataSourceSupplier']/method[@name='get' and count(parameter)=0]"
		[Register("get", "()Lcom/facebook/datasource/DataSource;", "GetGetHandler")]
		public virtual unsafe Java.Lang.Object Get() {
			const string __id = "get.()Lcom/facebook/datasource/DataSource;";
			var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
			var uncasted = global::Java.Lang.Object.GetObject<global::Com.Facebook.Datasource.IDataSource>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			return (Java.Lang.Object) uncasted;
		}
	}
}
