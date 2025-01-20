using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Config {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.config']/interface[@name='IParserInt']"
	[Register ("net/optifine/config/IParserInt", "", "Net.Optifine.Config.IParserIntInvoker")]
	public partial interface IParserInt : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.config']/interface[@name='IParserInt']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parse", "(Ljava/lang/String;I)I", "GetParse_Ljava_lang_String_IHandler:Net.Optifine.Config.IParserIntInvoker, AvventuraPokemon")]
		int Parse (string? p0, int p1);

	}

	[global::Android.Runtime.Register ("net/optifine/config/IParserInt", DoNotGenerateAcw=true)]
	internal partial class IParserIntInvoker : global::Java.Lang.Object, IParserInt {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/config/IParserInt", typeof (IParserIntInvoker));

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

		public static IParserInt? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParserInt> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.config.IParserInt'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParserIntInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_parse_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_IHandler ()
		{
			if (cb_parse_Ljava_lang_String_I == null)
				cb_parse_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Parse_Ljava_lang_String_I));
			return cb_parse_Ljava_lang_String_I;
		}

		static int n_Parse_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.IParserInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Parse (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Ljava_lang_String_I;
		public unsafe int Parse (string? p0, int p1)
		{
			if (id_parse_Ljava_lang_String_I == IntPtr.Zero)
				id_parse_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
