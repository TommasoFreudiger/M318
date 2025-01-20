using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Expr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionFloatArray']"
	[Register ("net/optifine/expr/IExpressionFloatArray", "", "Net.Optifine.Expr.IExpressionFloatArrayInvoker")]
	public partial interface IExpressionFloatArray : global::Net.Optifine.Expr.IExpression {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpressionFloatArray", typeof (IExpressionFloatArray), isInterface: true);

		private static Delegate? cb_getExpressionType;
#pragma warning disable 0169
		private static Delegate GetGetExpressionTypeHandler ()
		{
			if (cb_getExpressionType == null)
				cb_getExpressionType = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetExpressionType));
			return cb_getExpressionType;
		}

		private static IntPtr n_GetExpressionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionFloatArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ExpressionType);
		}
#pragma warning restore 0169

		virtual unsafe global::Net.Optifine.Expr.ExpressionType? ExpressionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionFloatArray']/method[@name='getExpressionType' and count(parameter)=0]"
			[Register ("getExpressionType", "()Lnet/optifine/expr/ExpressionType;", "GetGetExpressionTypeHandler:Net.Optifine.Expr.IExpressionFloatArray, AvventuraPokemon")]
			get {
				const string __id = "getExpressionType.()Lnet/optifine/expr/ExpressionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.ExpressionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionFloatArray']/method[@name='eval' and count(parameter)=0]"
		[Register ("eval", "()[F", "GetEvalHandler:Net.Optifine.Expr.IExpressionFloatArrayInvoker, AvventuraPokemon")]
		float[]? Eval ();

	}

	[global::Android.Runtime.Register ("net/optifine/expr/IExpressionFloatArray", DoNotGenerateAcw=true)]
	internal partial class IExpressionFloatArrayInvoker : global::Java.Lang.Object, IExpressionFloatArray {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpressionFloatArray", typeof (IExpressionFloatArrayInvoker));

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

		public static IExpressionFloatArray? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpressionFloatArray> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.expr.IExpressionFloatArray'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpressionFloatArrayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_eval;
#pragma warning disable 0169
		static Delegate GetEvalHandler ()
		{
			if (cb_eval == null)
				cb_eval = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Eval));
			return cb_eval;
		}

		static IntPtr n_Eval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionFloatArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Eval ());
		}
#pragma warning restore 0169

		IntPtr id_eval;
		public unsafe float[]? Eval ()
		{
			if (id_eval == IntPtr.Zero)
				id_eval = JNIEnv.GetMethodID (class_ref, "eval", "()[F");
			return (float[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eval), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

		static Delegate? cb_getExpressionType;
#pragma warning disable 0169
		static Delegate GetGetExpressionTypeHandler ()
		{
			if (cb_getExpressionType == null)
				cb_getExpressionType = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetExpressionType));
			return cb_getExpressionType;
		}

		static IntPtr n_GetExpressionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionFloatArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ExpressionType);
		}
#pragma warning restore 0169

		IntPtr id_getExpressionType;
		public unsafe global::Net.Optifine.Expr.ExpressionType? ExpressionType {
			get {
				if (id_getExpressionType == IntPtr.Zero)
					id_getExpressionType = JNIEnv.GetMethodID (class_ref, "getExpressionType", "()Lnet/optifine/expr/ExpressionType;");
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.ExpressionType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpressionType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
