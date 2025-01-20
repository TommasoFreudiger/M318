using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Json {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.json']/interface[@name='JSONAware']"
	[Register ("optifine/json/JSONAware", "", "Optifine.Json.IJSONAwareInvoker")]
	public partial interface IJSONAware : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='JSONAware']/method[@name='toJSONString' and count(parameter)=0]"
		[Register ("toJSONString", "()Ljava/lang/String;", "GetToJSONStringHandler:Optifine.Json.IJSONAwareInvoker, AvventuraPokemon")]
		string? ToJSONString ();

	}

	[global::Android.Runtime.Register ("optifine/json/JSONAware", DoNotGenerateAcw=true)]
	internal partial class IJSONAwareInvoker : global::Java.Lang.Object, IJSONAware {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/JSONAware", typeof (IJSONAwareInvoker));

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

		public static IJSONAware? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSONAware> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.json.JSONAware'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSONAwareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_toJSONString;
#pragma warning disable 0169
		static Delegate GetToJSONStringHandler ()
		{
			if (cb_toJSONString == null)
				cb_toJSONString = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ToJSONString));
			return cb_toJSONString;
		}

		static IntPtr n_ToJSONString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IJSONAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ToJSONString ());
		}
#pragma warning restore 0169

		IntPtr id_toJSONString;
		public unsafe string? ToJSONString ()
		{
			if (id_toJSONString == IntPtr.Zero)
				id_toJSONString = JNIEnv.GetMethodID (class_ref, "toJSONString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJSONString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
