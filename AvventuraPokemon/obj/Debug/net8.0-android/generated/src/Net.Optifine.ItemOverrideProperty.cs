//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine']/class[@name='ItemOverrideProperty']"
	[global::Android.Runtime.Register ("net/optifine/ItemOverrideProperty", DoNotGenerateAcw=true)]
	public partial class ItemOverrideProperty : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/ItemOverrideProperty", typeof (ItemOverrideProperty));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ItemOverrideProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetValues));
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.ItemOverrideProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='ItemOverrideProperty']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[F", "GetGetValuesHandler")]
		public virtual unsafe float[]? GetValues ()
		{
			const string __id = "getValues.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

	}
}
