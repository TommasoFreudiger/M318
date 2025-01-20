using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model.Anim {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IRenderResolver']"
	[Register ("net/optifine/entity/model/anim/IRenderResolver", "", "Net.Optifine.Entity.Model.Anim.IRenderResolverInvoker")]
	public partial interface IRenderResolver : IJavaObject, IJavaPeerable {
		bool IsTileEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IRenderResolver']/method[@name='isTileEntity' and count(parameter)=0]"
			[Register ("isTileEntity", "()Z", "GetIsTileEntityHandler:Net.Optifine.Entity.Model.Anim.IRenderResolverInvoker, AvventuraPokemon")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/interface[@name='IRenderResolver']/method[@name='getParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParameter", "(Ljava/lang/String;)Lnet/optifine/expr/IExpression;", "GetGetParameter_Ljava_lang_String_Handler:Net.Optifine.Entity.Model.Anim.IRenderResolverInvoker, AvventuraPokemon")]
		global::Net.Optifine.Expr.IExpression? GetParameter (string? p0);

	}

	[global::Android.Runtime.Register ("net/optifine/entity/model/anim/IRenderResolver", DoNotGenerateAcw=true)]
	internal partial class IRenderResolverInvoker : global::Java.Lang.Object, IRenderResolver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/IRenderResolver", typeof (IRenderResolverInvoker));

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

		public static IRenderResolver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRenderResolver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.entity.model.anim.IRenderResolver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRenderResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_isTileEntity;
#pragma warning disable 0169
		static Delegate GetIsTileEntityHandler ()
		{
			if (cb_isTileEntity == null)
				cb_isTileEntity = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsTileEntity));
			return cb_isTileEntity;
		}

		static bool n_IsTileEntity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IRenderResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTileEntity;
		}
#pragma warning restore 0169

		IntPtr id_isTileEntity;
		public unsafe bool IsTileEntity {
			get {
				if (id_isTileEntity == IntPtr.Zero)
					id_isTileEntity = JNIEnv.GetMethodID (class_ref, "isTileEntity", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTileEntity);
			}
		}

		static Delegate? cb_getParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getParameter_Ljava_lang_String_ == null)
				cb_getParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetParameter_Ljava_lang_String_));
			return cb_getParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.IRenderResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParameter_Ljava_lang_String_;
		public unsafe global::Net.Optifine.Expr.IExpression? GetParameter (string? p0)
		{
			if (id_getParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_getParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParameter", "(Ljava/lang/String;)Lnet/optifine/expr/IExpression;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Net.Optifine.Expr.IExpression> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
