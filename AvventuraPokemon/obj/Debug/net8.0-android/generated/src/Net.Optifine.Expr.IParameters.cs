using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Expr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IParameters']"
	[Register ("net/optifine/expr/IParameters", "", "Net.Optifine.Expr.IParametersInvoker")]
	public partial interface IParameters : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IParameters']/method[@name='getParameterTypes' and count(parameter)=1 and parameter[1][@type='net.optifine.expr.IExpression[]']]"
		[Register ("getParameterTypes", "([Lnet/optifine/expr/IExpression;)[Lnet/optifine/expr/ExpressionType;", "GetGetParameterTypes_arrayLnet_optifine_expr_IExpression_Handler:Net.Optifine.Expr.IParametersInvoker, AvventuraPokemon")]
		global::Net.Optifine.Expr.ExpressionType[]? GetParameterTypes (global::Net.Optifine.Expr.IExpression[]? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/expr/IParameters", DoNotGenerateAcw=true)]
	internal partial class IParametersInvoker : global::Java.Lang.Object, IParameters {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IParameters", typeof (IParametersInvoker));

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

		public static IParameters? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParameters> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.expr.IParameters'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParametersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getParameterTypes_arrayLnet_optifine_expr_IExpression_;
#pragma warning disable 0169
		static Delegate GetGetParameterTypes_arrayLnet_optifine_expr_IExpression_Handler ()
		{
			if (cb_getParameterTypes_arrayLnet_optifine_expr_IExpression_ == null)
				cb_getParameterTypes_arrayLnet_optifine_expr_IExpression_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetParameterTypes_arrayLnet_optifine_expr_IExpression_));
			return cb_getParameterTypes_arrayLnet_optifine_expr_IExpression_;
		}

		static IntPtr n_GetParameterTypes_arrayLnet_optifine_expr_IExpression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Net.Optifine.Expr.IExpression[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Net.Optifine.Expr.IExpression));
			IntPtr __ret = JNIEnv.NewArray (__this.GetParameterTypes (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParameterTypes_arrayLnet_optifine_expr_IExpression_;
		public unsafe global::Net.Optifine.Expr.ExpressionType[]? GetParameterTypes (global::Net.Optifine.Expr.IExpression[]? p0)
		{
			if (id_getParameterTypes_arrayLnet_optifine_expr_IExpression_ == IntPtr.Zero)
				id_getParameterTypes_arrayLnet_optifine_expr_IExpression_ = JNIEnv.GetMethodID (class_ref, "getParameterTypes", "([Lnet/optifine/expr/IExpression;)[Lnet/optifine/expr/ExpressionType;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (global::Net.Optifine.Expr.ExpressionType[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameterTypes_arrayLnet_optifine_expr_IExpression_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Net.Optifine.Expr.ExpressionType));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
