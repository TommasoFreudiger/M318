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

namespace Net.Optifine.Shaders {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']"
	[global::Android.Runtime.Register ("net/optifine/shaders/FlipTextures", DoNotGenerateAcw=true)]
	public partial class FlipTextures : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/FlipTextures", typeof (FlipTextures));

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

		protected FlipTextures (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/constructor[@name='FlipTextures' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe FlipTextures (string? name, int capacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (capacity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate? cb_capacity;
#pragma warning disable 0169
		static Delegate GetCapacityHandler ()
		{
			if (cb_capacity == null)
				cb_capacity = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Capacity));
			return cb_capacity;
		}

		static int n_Capacity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Capacity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()I", "GetCapacityHandler")]
		public virtual unsafe int Capacity ()
		{
			const string __id = "capacity.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Clear));
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lnet/optifine/shaders/FlipTextures;", "GetClearHandler")]
		public virtual unsafe global::Net.Optifine.Shaders.FlipTextures? Clear ()
		{
			const string __id = "clear.()Lnet/optifine/shaders/FlipTextures;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_deleteTextures;
#pragma warning disable 0169
		static Delegate GetDeleteTexturesHandler ()
		{
			if (cb_deleteTextures == null)
				cb_deleteTextures = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DeleteTextures));
			return cb_deleteTextures;
		}

		static void n_DeleteTextures (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DeleteTextures ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='deleteTextures' and count(parameter)=0]"
		[Register ("deleteTextures", "()V", "GetDeleteTexturesHandler")]
		public virtual unsafe void DeleteTextures ()
		{
			const string __id = "deleteTextures.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_fill_I;
#pragma warning disable 0169
		static Delegate GetFill_IHandler ()
		{
			if (cb_fill_I == null)
				cb_fill_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Fill_I));
			return cb_fill_I;
		}

		static void n_Fill_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Fill (val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fill", "(I)V", "GetFill_IHandler")]
		public virtual unsafe void Fill (int val)
		{
			const string __id = "fill.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_flip_I;
#pragma warning disable 0169
		static Delegate GetFlip_IHandler ()
		{
			if (cb_flip_I == null)
				cb_flip_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_Flip_I));
			return cb_flip_I;
		}

		static void n_Flip_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Flip (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='flip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("flip", "(I)V", "GetFlip_IHandler")]
		public virtual unsafe void Flip (int index)
		{
			const string __id = "flip.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_genTextures;
#pragma warning disable 0169
		static Delegate GetGenTexturesHandler ()
		{
			if (cb_genTextures == null)
				cb_genTextures = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_GenTextures));
			return cb_genTextures;
		}

		static void n_GenTextures (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.GenTextures ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='genTextures' and count(parameter)=0]"
		[Register ("genTextures", "()V", "GetGenTexturesHandler")]
		public virtual unsafe void GenTextures ()
		{
			const string __id = "genTextures.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_get_ZI;
#pragma warning disable 0169
		static Delegate GetGet_ZIHandler ()
		{
			if (cb_get_ZI == null)
				cb_get_ZI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZI_I (n_Get_ZI));
			return cb_get_ZI;
		}

		static int n_Get_ZI (IntPtr jnienv, IntPtr native__this, bool main, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Get (main, index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='get' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("get", "(ZI)I", "GetGet_ZIHandler")]
		public virtual unsafe int Get (bool main, int index)
		{
			const string __id = "get.(ZI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (main);
				__args [1] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_getA_I;
#pragma warning disable 0169
		static Delegate GetGetA_IHandler ()
		{
			if (cb_getA_I == null)
				cb_getA_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_GetA_I));
			return cb_getA_I;
		}

		static int n_GetA_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetA (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='getA' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getA", "(I)I", "GetGetA_IHandler")]
		public virtual unsafe int GetA (int index)
		{
			const string __id = "getA.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_getB_I;
#pragma warning disable 0169
		static Delegate GetGetB_IHandler ()
		{
			if (cb_getB_I == null)
				cb_getB_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_GetB_I));
			return cb_getB_I;
		}

		static int n_GetB_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetB (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='getB' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getB", "(I)I", "GetGetB_IHandler")]
		public virtual unsafe int GetB (int index)
		{
			const string __id = "getB.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_isChanged_I;
#pragma warning disable 0169
		static Delegate GetIsChanged_IHandler ()
		{
			if (cb_isChanged_I == null)
				cb_isChanged_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_Z (n_IsChanged_I));
			return cb_isChanged_I;
		}

		static bool n_IsChanged_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsChanged (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='isChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isChanged", "(I)Z", "GetIsChanged_IHandler")]
		public virtual unsafe bool IsChanged (int index)
		{
			const string __id = "isChanged.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_limit;
#pragma warning disable 0169
		static Delegate GetLimitHandler ()
		{
			if (cb_limit == null)
				cb_limit = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Limit));
			return cb_limit;
		}

		static int n_Limit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Limit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='limit' and count(parameter)=0]"
		[Register ("limit", "()I", "GetLimitHandler")]
		public virtual unsafe int Limit ()
		{
			const string __id = "limit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_limit_I;
#pragma warning disable 0169
		static Delegate GetLimit_IHandler ()
		{
			if (cb_limit_I == null)
				cb_limit_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_Limit_I));
			return cb_limit_I;
		}

		static IntPtr n_Limit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Limit (limit));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("limit", "(I)Lnet/optifine/shaders/FlipTextures;", "GetLimit_IHandler")]
		public virtual unsafe global::Net.Optifine.Shaders.FlipTextures? Limit (int limit)
		{
			const string __id = "limit.(I)Lnet/optifine/shaders/FlipTextures;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_position;
#pragma warning disable 0169
		static Delegate GetPositionHandler ()
		{
			if (cb_position == null)
				cb_position = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Position));
			return cb_position;
		}

		static int n_Position (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Position ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='position' and count(parameter)=0]"
		[Register ("position", "()I", "GetPositionHandler")]
		public virtual unsafe int Position ()
		{
			const string __id = "position.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_position_I;
#pragma warning disable 0169
		static Delegate GetPosition_IHandler ()
		{
			if (cb_position_I == null)
				cb_position_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_Position_I));
			return cb_position_I;
		}

		static IntPtr n_Position_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Position (position));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='position' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("position", "(I)Lnet/optifine/shaders/FlipTextures;", "GetPosition_IHandler")]
		public virtual unsafe global::Net.Optifine.Shaders.FlipTextures? Position (int position)
		{
			const string __id = "position.(I)Lnet/optifine/shaders/FlipTextures;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Reset));
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.FlipTextures> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='FlipTextures']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
