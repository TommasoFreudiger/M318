using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Json {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.json']/interface[@name='JSONStreamAware']"
	[Register ("optifine/json/JSONStreamAware", "", "Optifine.Json.IJSONStreamAwareInvoker")]
	public partial interface IJSONStreamAware : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='JSONStreamAware']/method[@name='writeJSONString' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("writeJSONString", "(Ljava/io/Writer;)V", "GetWriteJSONString_Ljava_io_Writer_Handler:Optifine.Json.IJSONStreamAwareInvoker, AvventuraPokemon")]
		void WriteJSONString (global::Java.IO.Writer? p0);

	}

	[global::Android.Runtime.Register ("optifine/json/JSONStreamAware", DoNotGenerateAcw=true)]
	internal partial class IJSONStreamAwareInvoker : global::Java.Lang.Object, IJSONStreamAware {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/JSONStreamAware", typeof (IJSONStreamAwareInvoker));

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

		public static IJSONStreamAware? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSONStreamAware> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.json.JSONStreamAware'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSONStreamAwareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_writeJSONString_Ljava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetWriteJSONString_Ljava_io_Writer_Handler ()
		{
			if (cb_writeJSONString_Ljava_io_Writer_ == null)
				cb_writeJSONString_Ljava_io_Writer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WriteJSONString_Ljava_io_Writer_));
			return cb_writeJSONString_Ljava_io_Writer_;
		}

		static void n_WriteJSONString_Ljava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IJSONStreamAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteJSONString (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeJSONString_Ljava_io_Writer_;
		public unsafe void WriteJSONString (global::Java.IO.Writer? p0)
		{
			if (id_writeJSONString_Ljava_io_Writer_ == IntPtr.Zero)
				id_writeJSONString_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "writeJSONString", "(Ljava/io/Writer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeJSONString_Ljava_io_Writer_, __args);
		}

	}
}
