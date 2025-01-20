using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Shaders {

	[Register ("net/optifine/shaders/ITextureFormat", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Net.Optifine.Shaders.ITextureFormat' type. This class will be removed in a future release.")]
	public abstract class TextureFormat : Java.Lang.Object {
		internal TextureFormat ()
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='readConfiguration' and count(parameter)=0]"
		[global::System.Obsolete (@"Use 'Net.Optifine.Shaders.ITextureFormat.ReadConfiguration'. This class will be removed in a future release.")]
		[Register ("readConfiguration", "()Lnet/optifine/shaders/ITextureFormat;", "")]
		public static unsafe global::Net.Optifine.Shaders.ITextureFormat? ReadConfiguration ()
		{
			const string __id = "readConfiguration.()Lnet/optifine/shaders/ITextureFormat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/ITextureFormat", typeof (TextureFormat));

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']"
	[Register ("net/optifine/shaders/ITextureFormat", "", "Net.Optifine.Shaders.ITextureFormatInvoker")]
	public partial interface ITextureFormat : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/ITextureFormat", typeof (ITextureFormat), isInterface: true);

		string? MacroName {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='getMacroName' and count(parameter)=0]"
			[Register ("getMacroName", "()Ljava/lang/String;", "GetGetMacroNameHandler:Net.Optifine.Shaders.ITextureFormatInvoker, AvventuraPokemon")]
			get; 
		}

		string? MacroVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='getMacroVersion' and count(parameter)=0]"
			[Register ("getMacroVersion", "()Ljava/lang/String;", "GetGetMacroVersionHandler:Net.Optifine.Shaders.ITextureFormatInvoker, AvventuraPokemon")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='getColorBlender' and count(parameter)=1 and parameter[1][@type='net.optifine.shaders.ShadersTextureType']]"
		[Register ("getColorBlender", "(Lnet/optifine/shaders/ShadersTextureType;)Lnet/optifine/texture/IColorBlender;", "GetGetColorBlender_Lnet_optifine_shaders_ShadersTextureType_Handler:Net.Optifine.Shaders.ITextureFormatInvoker, AvventuraPokemon")]
		global::Net.Optifine.Texture.IColorBlender? GetColorBlender (global::Net.Optifine.Shaders.ShadersTextureType? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='isTextureBlend' and count(parameter)=1 and parameter[1][@type='net.optifine.shaders.ShadersTextureType']]"
		[Register ("isTextureBlend", "(Lnet/optifine/shaders/ShadersTextureType;)Z", "GetIsTextureBlend_Lnet_optifine_shaders_ShadersTextureType_Handler:Net.Optifine.Shaders.ITextureFormatInvoker, AvventuraPokemon")]
		bool IsTextureBlend (global::Net.Optifine.Shaders.ShadersTextureType? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ITextureFormat']/method[@name='readConfiguration' and count(parameter)=0]"
		[Register ("readConfiguration", "()Lnet/optifine/shaders/ITextureFormat;", "")]
		public static unsafe global::Net.Optifine.Shaders.ITextureFormat? ReadConfiguration ()
		{
			const string __id = "readConfiguration.()Lnet/optifine/shaders/ITextureFormat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("net/optifine/shaders/ITextureFormat", DoNotGenerateAcw=true)]
	internal partial class ITextureFormatInvoker : global::Java.Lang.Object, ITextureFormat {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/ITextureFormat", typeof (ITextureFormatInvoker));

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

		public static ITextureFormat? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITextureFormat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.shaders.ITextureFormat'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITextureFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getMacroName;
#pragma warning disable 0169
		static Delegate GetGetMacroNameHandler ()
		{
			if (cb_getMacroName == null)
				cb_getMacroName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMacroName));
			return cb_getMacroName;
		}

		static IntPtr n_GetMacroName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.MacroName);
		}
#pragma warning restore 0169

		IntPtr id_getMacroName;
		public unsafe string? MacroName {
			get {
				if (id_getMacroName == IntPtr.Zero)
					id_getMacroName = JNIEnv.GetMethodID (class_ref, "getMacroName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMacroName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMacroVersion;
#pragma warning disable 0169
		static Delegate GetGetMacroVersionHandler ()
		{
			if (cb_getMacroVersion == null)
				cb_getMacroVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMacroVersion));
			return cb_getMacroVersion;
		}

		static IntPtr n_GetMacroVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.MacroVersion);
		}
#pragma warning restore 0169

		IntPtr id_getMacroVersion;
		public unsafe string? MacroVersion {
			get {
				if (id_getMacroVersion == IntPtr.Zero)
					id_getMacroVersion = JNIEnv.GetMethodID (class_ref, "getMacroVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMacroVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_;
#pragma warning disable 0169
		static Delegate GetGetColorBlender_Lnet_optifine_shaders_ShadersTextureType_Handler ()
		{
			if (cb_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_ == null)
				cb_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetColorBlender_Lnet_optifine_shaders_ShadersTextureType_));
			return cb_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_;
		}

		static IntPtr n_GetColorBlender_Lnet_optifine_shaders_ShadersTextureType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ShadersTextureType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetColorBlender (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_;
		public unsafe global::Net.Optifine.Texture.IColorBlender? GetColorBlender (global::Net.Optifine.Shaders.ShadersTextureType? p0)
		{
			if (id_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_ == IntPtr.Zero)
				id_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_ = JNIEnv.GetMethodID (class_ref, "getColorBlender", "(Lnet/optifine/shaders/ShadersTextureType;)Lnet/optifine/texture/IColorBlender;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Net.Optifine.Texture.IColorBlender> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorBlender_Lnet_optifine_shaders_ShadersTextureType_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_;
#pragma warning disable 0169
		static Delegate GetIsTextureBlend_Lnet_optifine_shaders_ShadersTextureType_Handler ()
		{
			if (cb_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_ == null)
				cb_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsTextureBlend_Lnet_optifine_shaders_ShadersTextureType_));
			return cb_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_;
		}

		static bool n_IsTextureBlend_Lnet_optifine_shaders_ShadersTextureType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ITextureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ShadersTextureType> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTextureBlend (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_;
		public unsafe bool IsTextureBlend (global::Net.Optifine.Shaders.ShadersTextureType? p0)
		{
			if (id_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_ == IntPtr.Zero)
				id_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_ = JNIEnv.GetMethodID (class_ref, "isTextureBlend", "(Lnet/optifine/shaders/ShadersTextureType;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTextureBlend_Lnet_optifine_shaders_ShadersTextureType_, __args);
			return __ret;
		}

	}
}
