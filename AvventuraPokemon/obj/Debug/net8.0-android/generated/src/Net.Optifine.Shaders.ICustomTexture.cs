using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Shaders {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ICustomTexture']"
	[Register ("net/optifine/shaders/ICustomTexture", "", "Net.Optifine.Shaders.ICustomTextureInvoker")]
	public partial interface ICustomTexture : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/ICustomTexture", typeof (ICustomTexture), isInterface: true);

		int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ICustomTexture']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler:Net.Optifine.Shaders.ICustomTextureInvoker, AvventuraPokemon")]
			get; 
		}

		int TextureUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ICustomTexture']/method[@name='getTextureUnit' and count(parameter)=0]"
			[Register ("getTextureUnit", "()I", "GetGetTextureUnitHandler:Net.Optifine.Shaders.ICustomTextureInvoker, AvventuraPokemon")]
			get; 
		}

		private static Delegate? cb_getTarget;
#pragma warning disable 0169
		private static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTarget));
			return cb_getTarget;
		}

		private static int n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ICustomTexture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Target;
		}
#pragma warning restore 0169

		virtual unsafe int Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ICustomTexture']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()I", "GetGetTargetHandler:Net.Optifine.Shaders.ICustomTexture, AvventuraPokemon")]
			get {
				const string __id = "getTarget.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/interface[@name='ICustomTexture']/method[@name='deleteTexture' and count(parameter)=0]"
		[Register ("deleteTexture", "()V", "GetDeleteTextureHandler:Net.Optifine.Shaders.ICustomTextureInvoker, AvventuraPokemon")]
		void DeleteTexture ();

	}

	[global::Android.Runtime.Register ("net/optifine/shaders/ICustomTexture", DoNotGenerateAcw=true)]
	internal partial class ICustomTextureInvoker : global::Java.Lang.Object, ICustomTexture {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/ICustomTexture", typeof (ICustomTextureInvoker));

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

		public static ICustomTexture? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomTexture> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.shaders.ICustomTexture'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomTextureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getTextureId;
#pragma warning disable 0169
		static Delegate GetGetTextureIdHandler ()
		{
			if (cb_getTextureId == null)
				cb_getTextureId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTextureId));
			return cb_getTextureId;
		}

		static int n_GetTextureId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ICustomTexture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.TextureId;
		}
#pragma warning restore 0169

		IntPtr id_getTextureId;
		public unsafe int TextureId {
			get {
				if (id_getTextureId == IntPtr.Zero)
					id_getTextureId = JNIEnv.GetMethodID (class_ref, "getTextureId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextureId);
			}
		}

		static Delegate? cb_getTextureUnit;
#pragma warning disable 0169
		static Delegate GetGetTextureUnitHandler ()
		{
			if (cb_getTextureUnit == null)
				cb_getTextureUnit = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetTextureUnit));
			return cb_getTextureUnit;
		}

		static int n_GetTextureUnit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ICustomTexture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.TextureUnit;
		}
#pragma warning restore 0169

		IntPtr id_getTextureUnit;
		public unsafe int TextureUnit {
			get {
				if (id_getTextureUnit == IntPtr.Zero)
					id_getTextureUnit = JNIEnv.GetMethodID (class_ref, "getTextureUnit", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextureUnit);
			}
		}

		static Delegate? cb_deleteTexture;
#pragma warning disable 0169
		static Delegate GetDeleteTextureHandler ()
		{
			if (cb_deleteTexture == null)
				cb_deleteTexture = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DeleteTexture));
			return cb_deleteTexture;
		}

		static void n_DeleteTexture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Shaders.ICustomTexture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DeleteTexture ();
		}
#pragma warning restore 0169

		IntPtr id_deleteTexture;
		public unsafe void DeleteTexture ()
		{
			if (id_deleteTexture == IntPtr.Zero)
				id_deleteTexture = JNIEnv.GetMethodID (class_ref, "deleteTexture", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteTexture);
		}

	}
}
