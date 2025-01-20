using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine']/interface[@name='IResourceProvider']"
	[Register ("optifine/IResourceProvider", "", "Optifine.IResourceProviderInvoker")]
	public partial interface IResourceProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine']/interface[@name='IResourceProvider']/method[@name='getResourceStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getResourceStream", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetGetResourceStream_Ljava_lang_String_Handler:Optifine.IResourceProviderInvoker, AvventuraPokemon")]
		global::System.IO.Stream? GetResourceStream (string? p0);

	}

	[global::Android.Runtime.Register ("optifine/IResourceProvider", DoNotGenerateAcw=true)]
	internal partial class IResourceProviderInvoker : global::Java.Lang.Object, IResourceProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/IResourceProvider", typeof (IResourceProviderInvoker));

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

		public static IResourceProvider? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.IResourceProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getResourceStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResourceStream_Ljava_lang_String_Handler ()
		{
			if (cb_getResourceStream_Ljava_lang_String_ == null)
				cb_getResourceStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetResourceStream_Ljava_lang_String_));
			return cb_getResourceStream_Ljava_lang_String_;
		}

		static IntPtr n_GetResourceStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.IResourceProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetResourceStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResourceStream_Ljava_lang_String_;
		public unsafe global::System.IO.Stream? GetResourceStream (string? p0)
		{
			if (id_getResourceStream_Ljava_lang_String_ == IntPtr.Zero)
				id_getResourceStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResourceStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
