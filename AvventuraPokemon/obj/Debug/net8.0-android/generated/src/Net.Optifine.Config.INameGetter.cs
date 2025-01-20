using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.config']/interface[@name='INameGetter']"
	[Register ("net/optifine/config/INameGetter", "", "Net.Optifine.Config.INameGetterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface INameGetter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.config']/interface[@name='INameGetter']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getName", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetName_Ljava_lang_Object_Handler:Net.Optifine.Config.INameGetterInvoker, AvventuraPokemon")]
		string? GetName (global::Java.Lang.Object? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/config/INameGetter", DoNotGenerateAcw=true)]
	internal partial class INameGetterInvoker : global::Java.Lang.Object, INameGetter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/config/INameGetter", typeof (INameGetterInvoker));

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

		public static INameGetter? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INameGetter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.config.INameGetter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INameGetterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getName_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetName_Ljava_lang_Object_Handler ()
		{
			if (cb_getName_Ljava_lang_Object_ == null)
				cb_getName_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetName_Ljava_lang_Object_));
			return cb_getName_Ljava_lang_Object_;
		}

		static IntPtr n_GetName_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.INameGetter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getName_Ljava_lang_Object_;
		public unsafe string? GetName (global::Java.Lang.Object? p0)
		{
			if (id_getName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getName_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getName", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
