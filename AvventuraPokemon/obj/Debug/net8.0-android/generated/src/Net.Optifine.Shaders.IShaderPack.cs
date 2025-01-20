using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Shaders {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='IShaderPack']"
	[Register ("net/optifine/shaders/IShaderPack", "", "Net.Optifine.Shaders.IShaderPackInvoker")]
	public partial interface IShaderPack : IJavaObject, IJavaPeerable {
		string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='IShaderPack']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Net.Optifine.Shaders.IShaderPackInvoker, AvventuraPokemon")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='IShaderPack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Net.Optifine.Shaders.IShaderPackInvoker, AvventuraPokemon")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='IShaderPack']/method[@name='getResourceAsStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetGetResourceAsStream_Ljava_lang_String_Handler:Net.Optifine.Shaders.IShaderPackInvoker, AvventuraPokemon")]
		global::System.IO.Stream? GetResourceAsStream (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='IShaderPack']/method[@name='hasDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasDirectory", "(Ljava/lang/String;)Z", "GetHasDirectory_Ljava_lang_String_Handler:Net.Optifine.Shaders.IShaderPackInvoker, AvventuraPokemon")]
		bool HasDirectory (string? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/shaders/IShaderPack", DoNotGenerateAcw=true)]
	internal partial class IShaderPackInvoker : global::Java.Lang.Object, IShaderPack {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/IShaderPack", typeof (IShaderPackInvoker));

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

		public static IShaderPack? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShaderPack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.shaders.IShaderPack'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShaderPackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.IShaderPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string? Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Close));
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.IShaderPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate? cb_getResourceAsStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResourceAsStream_Ljava_lang_String_Handler ()
		{
			if (cb_getResourceAsStream_Ljava_lang_String_ == null)
				cb_getResourceAsStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetResourceAsStream_Ljava_lang_String_));
			return cb_getResourceAsStream_Ljava_lang_String_;
		}

		static IntPtr n_GetResourceAsStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.IShaderPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetResourceAsStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResourceAsStream_Ljava_lang_String_;
		public unsafe global::System.IO.Stream? GetResourceAsStream (string? p0)
		{
			if (id_getResourceAsStream_Ljava_lang_String_ == IntPtr.Zero)
				id_getResourceAsStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceAsStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_hasDirectory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasDirectory_Ljava_lang_String_Handler ()
		{
			if (cb_hasDirectory_Ljava_lang_String_ == null)
				cb_hasDirectory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_HasDirectory_Ljava_lang_String_));
			return cb_hasDirectory_Ljava_lang_String_;
		}

		static bool n_HasDirectory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.IShaderPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasDirectory (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hasDirectory_Ljava_lang_String_;
		public unsafe bool HasDirectory (string? p0)
		{
			if (id_hasDirectory_Ljava_lang_String_ == IntPtr.Zero)
				id_hasDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasDirectory", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDirectory_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
