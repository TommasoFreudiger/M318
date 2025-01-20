using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.config']/interface[@name='ToBooleanFunction']"
	[Register ("net/optifine/config/ToBooleanFunction", "", "Net.Optifine.Config.IToBooleanFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IToBooleanFunction : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.config']/interface[@name='ToBooleanFunction']/method[@name='applyAsBool' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("applyAsBool", "(Ljava/lang/Object;)Z", "GetApplyAsBool_Ljava_lang_Object_Handler:Net.Optifine.Config.IToBooleanFunctionInvoker, AvventuraPokemon")]
		bool ApplyAsBool (global::Java.Lang.Object? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/config/ToBooleanFunction", DoNotGenerateAcw=true)]
	internal partial class IToBooleanFunctionInvoker : global::Java.Lang.Object, IToBooleanFunction {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/config/ToBooleanFunction", typeof (IToBooleanFunctionInvoker));

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

		public static IToBooleanFunction? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToBooleanFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.config.ToBooleanFunction'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IToBooleanFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_applyAsBool_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApplyAsBool_Ljava_lang_Object_Handler ()
		{
			if (cb_applyAsBool_Ljava_lang_Object_ == null)
				cb_applyAsBool_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_ApplyAsBool_Ljava_lang_Object_));
			return cb_applyAsBool_Ljava_lang_Object_;
		}

		static bool n_ApplyAsBool_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.IToBooleanFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplyAsBool (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_applyAsBool_Ljava_lang_Object_;
		public unsafe bool ApplyAsBool (global::Java.Lang.Object? p0)
		{
			if (id_applyAsBool_Ljava_lang_Object_ == IntPtr.Zero)
				id_applyAsBool_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "applyAsBool", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_applyAsBool_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
