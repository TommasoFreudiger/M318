using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Expr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpression']"
	[Register ("net/optifine/expr/IExpression", "", "Net.Optifine.Expr.IExpressionInvoker")]
	public partial interface IExpression : IJavaObject, IJavaPeerable {
		global::Net.Optifine.Expr.ExpressionType? ExpressionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.expr']/interface[@name='IExpression']/method[@name='getExpressionType' and count(parameter)=0]"
			[Register ("getExpressionType", "()Lnet/optifine/expr/ExpressionType;", "GetGetExpressionTypeHandler:Net.Optifine.Expr.IExpressionInvoker, AvventuraPokemon")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("net/optifine/expr/IExpression", DoNotGenerateAcw=true)]
	internal partial class IExpressionInvoker : global::Java.Lang.Object, IExpression {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/expr/IExpression", typeof (IExpressionInvoker));

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

		public static IExpression? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpression> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.expr.IExpression'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpressionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
