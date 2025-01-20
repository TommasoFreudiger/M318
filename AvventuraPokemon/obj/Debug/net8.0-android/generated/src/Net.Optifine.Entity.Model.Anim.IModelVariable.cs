using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model.Anim {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariable']"
	[Register ("net/optifine/entity/model/anim/IModelVariable", "", "Net.Optifine.Entity.Model.Anim.IModelVariableInvoker")]
	public partial interface IModelVariable : global::Net.Optifine.Expr.IExpression {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariable']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='net.optifine.expr.IExpression']]"
		[Register ("setValue", "(Lnet/optifine/expr/IExpression;)V", "GetSetValue_Lnet_optifine_expr_IExpression_Handler:Net.Optifine.Entity.Model.Anim.IModelVariableInvoker, AvventuraPokemon")]
		void SetValue (global::Net.Optifine.Expr.IExpression? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/entity/model/anim/IModelVariable", DoNotGenerateAcw=true)]
	internal partial class IModelVariableInvoker : global::Java.Lang.Object, IModelVariable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IModelVariable", typeof (IModelVariableInvoker));

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

		public static IModelVariable? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModelVariable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.entity.model.anim.IModelVariable'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModelVariableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_setValue_Lnet_optifine_expr_IExpression_;
#pragma warning disable 0169
		static Delegate GetSetValue_Lnet_optifine_expr_IExpression_Handler ()
		{
			if (cb_setValue_Lnet_optifine_expr_IExpression_ == null)
				cb_setValue_Lnet_optifine_expr_IExpression_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetValue_Lnet_optifine_expr_IExpression_));
			return cb_setValue_Lnet_optifine_expr_IExpression_;
		}

		static void n_SetValue_Lnet_optifine_expr_IExpression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Net.Optifine.Expr.IExpression?)global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0);
		}
#pragma warning restore 0169

		IntPtr id_setValue_Lnet_optifine_expr_IExpression_;
		public unsafe void SetValue (global::Net.Optifine.Expr.IExpression? p0)
		{
			if (id_setValue_Lnet_optifine_expr_IExpression_ == IntPtr.Zero)
				id_setValue_Lnet_optifine_expr_IExpression_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Lnet/optifine/expr/IExpression;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Lnet_optifine_expr_IExpression_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
