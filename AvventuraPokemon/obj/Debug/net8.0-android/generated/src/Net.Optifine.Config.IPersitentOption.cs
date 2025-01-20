using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.config']/interface[@name='IPersitentOption']"
	[Register ("net/optifine/config/IPersitentOption", "", "Net.Optifine.Config.IPersitentOptionInvoker")]
	public partial interface IPersitentOption : IJavaObject, IJavaPeerable {
		string? SaveKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.config']/interface[@name='IPersitentOption']/method[@name='getSaveKey' and count(parameter)=0]"
			[Register ("getSaveKey", "()Ljava/lang/String;", "GetGetSaveKeyHandler:Net.Optifine.Config.IPersitentOptionInvoker, AvventuraPokemon")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("net/optifine/config/IPersitentOption", DoNotGenerateAcw=true)]
	internal partial class IPersitentOptionInvoker : global::Java.Lang.Object, IPersitentOption {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/config/IPersitentOption", typeof (IPersitentOptionInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPersitentOption? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersitentOption> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.config.IPersitentOption'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersitentOptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getSaveKey;
#pragma warning disable 0169
		static Delegate GetGetSaveKeyHandler ()
		{
			if (cb_getSaveKey == null)
				cb_getSaveKey = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSaveKey));
			return cb_getSaveKey;
		}

		static IntPtr n_GetSaveKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.IPersitentOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SaveKey);
		}
#pragma warning restore 0169

		IntPtr id_getSaveKey;
		public unsafe string? SaveKey {
			get {
				if (id_getSaveKey == IntPtr.Zero)
					id_getSaveKey = JNIEnv.GetMethodID (class_ref, "getSaveKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSaveKey), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
