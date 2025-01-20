using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model.Anim {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableBool']"
	[Register ("net/optifine/entity/model/anim/IModelVariableBool", "", "Net.Optifine.Entity.Model.Anim.IModelVariableBoolInvoker")]
	public partial interface IModelVariableBool : global::Net.Optifine.Entity.Model.Anim.IModelVariable, global::Net.Optifine.Expr.IExpressionBool {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IModelVariableBool", typeof (IModelVariableBool), isInterface: true);

		bool Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableBool']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Z", "GetGetValueHandler:Net.Optifine.Entity.Model.Anim.IModelVariableBoolInvoker, AvventuraPokemon")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableBool']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setValue", "(Z)V", "GetSetValue_ZHandler:Net.Optifine.Entity.Model.Anim.IModelVariableBoolInvoker, AvventuraPokemon")]
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var expr = (global::Net.Optifine.Expr.IExpression?)global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (native_expr, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (expr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IModelVariableBool']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='net.optifine.expr.IExpression']]"
		[Register ("setValue", "(Lnet/optifine/expr/IExpression;)V", "GetSetValue_Lnet_optifine_expr_IExpression_Handler:Net.Optifine.Entity.Model.Anim.IModelVariableBool, AvventuraPokemon")]
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

	[global::Android.Runtime.Register ("net/optifine/entity/model/anim/IModelVariableBool", DoNotGenerateAcw=true)]
	internal partial class IModelVariableBoolInvoker : global::Java.Lang.Object, IModelVariableBool {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IModelVariableBool", typeof (IModelVariableBoolInvoker));

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

		public static IModelVariableBool? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModelVariableBool> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.entity.model.anim.IModelVariableBool'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModelVariableBoolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_getValue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetValue));
			return cb_getValue;
		}

		static bool n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Value;
		}
#pragma warning restore 0169

		static Delegate? cb_setValue_Z;
#pragma warning disable 0169
		static Delegate GetSetValue_ZHandler ()
		{
			if (cb_setValue_Z == null)
				cb_setValue_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetValue_Z));
			return cb_setValue_Z;
		}

		static void n_SetValue_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Value = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		IntPtr id_setValue_Z;
		public unsafe bool Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
			}
			set {
				if (id_setValue_Z == IntPtr.Zero)
					id_setValue_Z = JNIEnv.GetMethodID (class_ref, "setValue", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Z, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
				cb_eval = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_Eval));
			return cb_eval;
		}

		static bool n_Eval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IModelVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

	}
}
