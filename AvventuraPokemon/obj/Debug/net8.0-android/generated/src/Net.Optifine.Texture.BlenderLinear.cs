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

namespace Net.Optifine.Texture {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.texture']/class[@name='BlenderLinear']"
	[global::Android.Runtime.Register ("net/optifine/texture/BlenderLinear", DoNotGenerateAcw=true)]
	public partial class BlenderLinear : global::Java.Lang.Object, global::Net.Optifine.Texture.IBlender {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/texture/BlenderLinear", typeof (BlenderLinear));

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

		protected BlenderLinear (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.texture']/class[@name='BlenderLinear']/constructor[@name='BlenderLinear' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlenderLinear () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_blend_IIII;
#pragma warning disable 0169
		static Delegate GetBlend_IIIIHandler ()
		{
			if (cb_blend_IIII == null)
				cb_blend_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIII_I (n_Blend_IIII));
			return cb_blend_IIII;
		}

		static int n_Blend_IIII (IntPtr jnienv, IntPtr native__this, int v1, int v2, int v3, int v4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Texture.BlenderLinear> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Blend (v1, v2, v3, v4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.texture']/class[@name='BlenderLinear']/method[@name='blend' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("blend", "(IIII)I", "GetBlend_IIIIHandler")]
		public virtual unsafe int Blend (int v1, int v2, int v3, int v4)
		{
			const string __id = "blend.(IIII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (v1);
				__args [1] = new JniArgumentValue (v2);
				__args [2] = new JniArgumentValue (v3);
				__args [3] = new JniArgumentValue (v4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
