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

namespace Net.Optifine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']"
	[global::Android.Runtime.Register ("net/optifine/util/CompoundKey", DoNotGenerateAcw=true)]
	public partial class CompoundKey : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/util/CompoundKey", typeof (CompoundKey));

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

		protected CompoundKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']/constructor[@name='CompoundKey' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe CompoundKey (global::Java.Lang.Object? k1, global::Java.Lang.Object? k2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((k1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k1).Handle);
				__args [1] = new JniArgumentValue ((k2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (k1);
				global::System.GC.KeepAlive (k2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']/constructor[@name='CompoundKey' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe CompoundKey (global::Java.Lang.Object? k1, global::Java.Lang.Object? k2, global::Java.Lang.Object? k3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((k1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k1).Handle);
				__args [1] = new JniArgumentValue ((k2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k2).Handle);
				__args [2] = new JniArgumentValue ((k3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (k1);
				global::System.GC.KeepAlive (k2);
				global::System.GC.KeepAlive (k3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']/constructor[@name='CompoundKey' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe CompoundKey (global::Java.Lang.Object? k1, global::Java.Lang.Object? k2, global::Java.Lang.Object? k3, global::Java.Lang.Object? k4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((k1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k1).Handle);
				__args [1] = new JniArgumentValue ((k2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k2).Handle);
				__args [2] = new JniArgumentValue ((k3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k3).Handle);
				__args [3] = new JniArgumentValue ((k4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k4).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (k1);
				global::System.GC.KeepAlive (k2);
				global::System.GC.KeepAlive (k3);
				global::System.GC.KeepAlive (k4);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']/constructor[@name='CompoundKey' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe CompoundKey (global::Java.Lang.Object[]? keys) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keys = JNIEnv.NewArray (keys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keys);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (keys != null) {
					JNIEnv.CopyArray (native_keys, keys);
					JNIEnv.DeleteLocalRef (native_keys);
				}
				global::System.GC.KeepAlive (keys);
			}
		}

		static Delegate? cb_getKeysCopy;
#pragma warning disable 0169
		static Delegate GetGetKeysCopyHandler ()
		{
			if (cb_getKeysCopy == null)
				cb_getKeysCopy = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetKeysCopy));
			return cb_getKeysCopy;
		}

		static IntPtr n_GetKeysCopy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Util.CompoundKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetKeysCopy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='CompoundKey']/method[@name='getKeysCopy' and count(parameter)=0]"
		[Register ("getKeysCopy", "()[Ljava/lang/Object;", "GetGetKeysCopyHandler")]
		public virtual unsafe global::Java.Lang.Object[]? GetKeysCopy ()
		{
			const string __id = "getKeysCopy.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

	}
}
