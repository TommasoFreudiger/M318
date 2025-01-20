using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Expr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionBool']"
	[Register ("net/optifine/expr/IExpressionBool", "", "Net.Optifine.Expr.IExpressionBoolInvoker")]
	public partial interface IExpressionBool : global::Net.Optifine.Expr.IExpression {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpressionBool", typeof (IExpressionBool), isInterface: true);

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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ExpressionType);
		}
#pragma warning restore 0169

		virtual unsafe global::Net.Optifine.Expr.ExpressionType? ExpressionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionBool']/method[@name='getExpressionType' and count(parameter)=0]"
			[Register ("getExpressionType", "()Lnet/optifine/expr/ExpressionType;", "GetGetExpressionTypeHandler:Net.Optifine.Expr.IExpressionBool, AvventuraPokemon")]
			get {
				const string __id = "getExpressionType.()Lnet/optifine/expr/ExpressionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.ExpressionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpressionBool']/method[@name='eval' and count(parameter)=0]"
		[Register ("eval", "()Z", "GetEvalHandler:Net.Optifine.Expr.IExpressionBoolInvoker, AvventuraPokemon")]
		bool Eval ();

	}

	[global::Android.Runtime.Register ("net/optifine/expr/IExpressionBool", DoNotGenerateAcw=true)]
	internal partial class IExpressionBoolInvoker : global::Java.Lang.Object, IExpressionBool {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpressionBool", typeof (IExpressionBoolInvoker));

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

		public static IExpressionBool? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpressionBool> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.expr.IExpressionBool'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpressionBoolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_eval = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_Eval));
			return cb_eval;
		}

		static bool n_Eval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Eval ();
		}
#pragma warning restore 0169

		IntPtr id_eval;
		public unsafe bool Eval ()
		{
			if (id_eval == IntPtr.Zero)
				id_eval = JNIEnv.GetMethodID (class_ref, "eval", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_eval);
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpressionBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
