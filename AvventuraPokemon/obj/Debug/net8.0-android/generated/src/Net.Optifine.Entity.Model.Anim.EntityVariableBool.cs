//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model.Anim {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.entity.model.anim']/class[@name='EntityVariableBool']"
	[global::Android.Runtime.Register ("net/optifine/entity/model/anim/EntityVariableBool", DoNotGenerateAcw=true)]
	public partial class EntityVariableBool : global::Java.Lang.Object, global::Net.Optifine.Entity.Model.Anim.IModelVariableBool {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/anim/EntityVariableBool", typeof (EntityVariableBool));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected EntityVariableBool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.entity.model.anim']/class[@name='EntityVariableBool']/constructor[@name='EntityVariableBool' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe EntityVariableBool (string? name) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.EntityVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static void n_SetValue_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.EntityVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Value = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/class[@name='EntityVariableBool']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Z", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/class[@name='EntityVariableBool']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setValue", "(Z)V", "GetSetValue_ZHandler")]
			set {
				const string __id = "setValue.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.Anim.EntityVariableBool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Eval ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model.anim']/class[@name='EntityVariableBool']/method[@name='eval' and count(parameter)=0]"
		[Register ("eval", "()Z", "GetEvalHandler")]
		public virtual unsafe bool Eval ()
		{
			const string __id = "eval.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
