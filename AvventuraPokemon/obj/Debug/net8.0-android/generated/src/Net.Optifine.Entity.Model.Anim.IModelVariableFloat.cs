using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model.Anim {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableFloat']"
	[Register ("net/optifine/entity/model/anim/IModelVariableFloat", "", "Net.Optifine.Entity.Model.Anim.IModelVariableFloatInvoker")]
	public partial interface IModelVariableFloat : global::Net.Optifine.Entity.Model.Anim.IModelVariable, global::Net.Optifine.Expr.IExpressionFloat {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IModelVariableFloat", typeof (IModelVariableFloat), isInterface: true);

		float Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableFloat']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()F", "GetGetValueHandler:Net.Optifine.Entity.Model.Anim.IModelVariableFloatInvoker, AvventuraPokemon")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableFloat']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValue", "(F)V", "GetSetValue_FHandler:Net.Optifine.Entity.Model.Anim.IModelVariableFloatInvoker, AvventuraPokemon")]
			set; 
		}

		private static Delegate? cb_setValue_Lnet_optifine_expr_IExpression_;
#pragma warning disable 0169
		private static Delegate GetSetValue_Lnet_optifine_expr_IExpression_Handler ()
		{
			if (cb_setValue_Lnet_optifine_expr_IExpression_ == null)
				cb_setValue_Lnet_optifine_expr_IExpression_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetValue_Lnet_optifine_expr_IExpression_));
			return cb_setValue_Lnet_optifine_expr_IExpression_;
		}

		private static void n_SetValue_Lnet_optifine_expr_IExpression_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var expr = (global::Net.Optifine.Expr.IExpression?)global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (native_expr, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (expr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableFloat']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='net.optifine.expr.IExpression']]"
		[Register ("setValue", "(Lnet/optifine/expr/IExpression;)V", "GetSetValue_Lnet_optifine_expr_IExpression_Handler:Net.Optifine.Entity.Model.Anim.IModelVariableFloat, AvventuraPokemon")]
		unsafe void Net.Optifine.Entity.Model.Anim.IModelVariable.SetValue (global::Net.Optifine.Expr.IExpression? expr)
		{
			const string __id = "setValue.(Lnet/optifine/expr/IExpression;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((expr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expr).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (expr);
			}
		}

	}

	[global::Android.Runtime.Register ("net/optifine/entity/model/anim/IModelVariableFloat", DoNotGenerateAcw=true)]
	internal partial class IModelVariableFloatInvoker : global::Java.Lang.Object, IModelVariableFloat {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IModelVariableFloat", typeof (IModelVariableFloatInvoker));

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

		public static IModelVariableFloat? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModelVariableFloat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.entity.model.anim.IModelVariableFloat'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModelVariableFloatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_GetValue));
			return cb_getValue;
		}

		static float n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Value;
		}
#pragma warning restore 0169

		static Delegate? cb_setValue_F;
#pragma warning disable 0169
		static Delegate GetSetValue_FHandler ()
		{
			if (cb_setValue_F == null)
				cb_setValue_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPF_V (n_SetValue_F));
			return cb_setValue_F;
		}

		static void n_SetValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Value = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		IntPtr id_setValue_F;
		public unsafe float Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
			}
			set {
				if (id_setValue_F == IntPtr.Zero)
					id_setValue_F = JNIEnv.GetMethodID (class_ref, "setValue", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_F, __args);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_eval;
#pragma warning disable 0169
		static Delegate GetEvalHandler ()
		{
			if (cb_eval == null)
				cb_eval = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_Eval));
			return cb_eval;
		}

		static float n_Eval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Eval ();
		}
#pragma warning restore 0169

		IntPtr id_eval;
		public unsafe float Eval ()
		{
			if (id_eval == IntPtr.Zero)
				id_eval = JNIEnv.GetMethodID (class_ref, "eval", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_eval);
		}

	}
}
