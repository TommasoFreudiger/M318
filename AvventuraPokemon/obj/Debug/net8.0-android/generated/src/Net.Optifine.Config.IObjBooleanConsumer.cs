using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.config']/interface[@name='ObjBooleanConsumer']"
	[Register ("net/optifine/config/ObjBooleanConsumer", "", "Net.Optifine.Config.IObjBooleanConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IObjBooleanConsumer : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.config']/interface[@name='ObjBooleanConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("accept", "(Ljava/lang/Object;Ljava/lang/Boolean;)V", "GetAccept_Ljava_lang_Object_Ljava_lang_Boolean_Handler:Net.Optifine.Config.IObjBooleanConsumerInvoker, AvventuraPokemon")]
		void Accept (global::Java.Lang.Object? p0, global::Java.Lang.Boolean? p1);

	}

	[global::Android.Runtime.Register ("net/optifine/config/ObjBooleanConsumer", DoNotGenerateAcw=true)]
	internal partial class IObjBooleanConsumerInvoker : global::Java.Lang.Object, IObjBooleanConsumer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/config/ObjBooleanConsumer", typeof (IObjBooleanConsumerInvoker));

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

		public static IObjBooleanConsumer? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjBooleanConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.config.ObjBooleanConsumer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjBooleanConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_accept_Ljava_lang_Object_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_Ljava_lang_Boolean_Handler ()
		{
			if (cb_accept_Ljava_lang_Object_Ljava_lang_Boolean_ == null)
				cb_accept_Ljava_lang_Object_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Accept_Ljava_lang_Object_Ljava_lang_Boolean_));
			return cb_accept_Ljava_lang_Object_Ljava_lang_Boolean_;
		}

		static void n_Accept_Ljava_lang_Object_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.IObjBooleanConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_Ljava_lang_Boolean_;
		public unsafe void Accept (global::Java.Lang.Object? p0, global::Java.Lang.Boolean? p1)
		{
			if (id_accept_Ljava_lang_Object_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;Ljava/lang/Boolean;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_Ljava_lang_Boolean_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
