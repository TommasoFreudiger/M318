using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Expr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionResolver']"
	[Register ("net/optifine/expr/IExpressionResolver", "", "Net.Optifine.Expr.IExpressionResolverInvoker")]
	public partial interface IExpressionResolver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionResolver']/method[@name='getExpression' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExpression", "(Ljava/lang/String;)Lnet/optifine/expr/IExpression;", "GetGetExpression_Ljava_lang_String_Handler:Net.Optifine.Expr.IExpressionResolverInvoker, AvventuraPokemon")]
		global::Net.Optifine.Expr.IExpression? GetExpression (string? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/expr/IExpressionResolver", DoNotGenerateAcw=true)]
	internal partial class IExpressionResolverInvoker : global::Java.Lang.Object, IExpressionResolver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpressionResolver", typeof (IExpressionResolverInvoker));

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

		public static IExpressionResolver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpressionResolver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.expr.IExpressionResolver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpressionResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getExpression_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExpression_Ljava_lang_String_Handler ()
		{
			if (cb_getExpression_Ljava_lang_String_ == null)
				cb_getExpression_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetExpression_Ljava_lang_String_));
			return cb_getExpression_Ljava_lang_String_;
		}

		static IntPtr n_GetExpression_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExpression (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getExpression_Ljava_lang_String_;
		public unsafe global::Net.Optifine.Expr.IExpression? GetExpression (string? p0)
		{
			if (id_getExpression_Ljava_lang_String_ == IntPtr.Zero)
				id_getExpression_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExpression", "(Ljava/lang/String;)Lnet/optifine/expr/IExpression;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpression_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
