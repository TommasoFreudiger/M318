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

namespace Net.Optifine.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.player']/class[@name='CapeImageBuffer']"
	[global::Android.Runtime.Register ("net/optifine/player/CapeImageBuffer", DoNotGenerateAcw=true)]
	public partial class CapeImageBuffer : global::Java.Lang.Object, global::Java.Lang.IRunnable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/player/CapeImageBuffer", typeof (CapeImageBuffer));

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

		protected CapeImageBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_isElytraOfCape;
#pragma warning disable 0169
		static Delegate GetIsElytraOfCapeHandler ()
		{
			if (cb_isElytraOfCape == null)
				cb_isElytraOfCape = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsElytraOfCape));
			return cb_isElytraOfCape;
		}

		static bool n_IsElytraOfCape (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Player.CapeImageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsElytraOfCape;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsElytraOfCape {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.player']/class[@name='CapeImageBuffer']/method[@name='isElytraOfCape' and count(parameter)=0]"
			[Register ("isElytraOfCape", "()Z", "GetIsElytraOfCapeHandler")]
			get {
				const string __id = "isElytraOfCape.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Cleanup));
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Player.CapeImageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Cleanup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.player']/class[@name='CapeImageBuffer']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			const string __id = "cleanup.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Run));
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Player.CapeImageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.player']/class[@name='CapeImageBuffer']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_skinAvailable;
#pragma warning disable 0169
		static Delegate GetSkinAvailableHandler ()
		{
			if (cb_skinAvailable == null)
				cb_skinAvailable = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SkinAvailable));
			return cb_skinAvailable;
		}

		static void n_SkinAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Player.CapeImageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SkinAvailable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.player']/class[@name='CapeImageBuffer']/method[@name='skinAvailable' and count(parameter)=0]"
		[Register ("skinAvailable", "()V", "GetSkinAvailableHandler")]
		public virtual unsafe void SkinAvailable ()
		{
			const string __id = "skinAvailable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
