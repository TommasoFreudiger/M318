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

namespace Net.Optifine.Render {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.render']/class[@name='SpriteRenderData']"
	[global::Android.Runtime.Register ("net/optifine/render/SpriteRenderData", DoNotGenerateAcw=true)]
	public partial class SpriteRenderData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/render/SpriteRenderData", typeof (SpriteRenderData));

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

		protected SpriteRenderData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getCounts;
#pragma warning disable 0169
		static Delegate GetGetCountsHandler ()
		{
			if (cb_getCounts == null)
				cb_getCounts = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCounts));
			return cb_getCounts;
		}

		static IntPtr n_GetCounts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Render.SpriteRenderData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCounts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.render']/class[@name='SpriteRenderData']/method[@name='getCounts' and count(parameter)=0]"
		[Register ("getCounts", "()[I", "GetGetCountsHandler")]
		public virtual unsafe int[]? GetCounts ()
		{
			const string __id = "getCounts.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate? cb_getPositions;
#pragma warning disable 0169
		static Delegate GetGetPositionsHandler ()
		{
			if (cb_getPositions == null)
				cb_getPositions = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPositions));
			return cb_getPositions;
		}

		static IntPtr n_GetPositions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Render.SpriteRenderData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetPositions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.render']/class[@name='SpriteRenderData']/method[@name='getPositions' and count(parameter)=0]"
		[Register ("getPositions", "()[I", "GetGetPositionsHandler")]
		public virtual unsafe int[]? GetPositions ()
		{
			const string __id = "getPositions.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
