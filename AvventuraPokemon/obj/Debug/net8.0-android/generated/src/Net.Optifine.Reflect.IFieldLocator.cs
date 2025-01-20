using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.reflect']/interface[@name='IFieldLocator']"
	[Register ("net/optifine/reflect/IFieldLocator", "", "Net.Optifine.Reflect.IFieldLocatorInvoker")]
	public partial interface IFieldLocator : IJavaObject, IJavaPeerable {
		global::Java.Lang.Reflect.Field? Field {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.reflect']/interface[@name='IFieldLocator']/method[@name='getField' and count(parameter)=0]"
			[Register ("getField", "()Ljava/lang/reflect/Field;", "GetGetFieldHandler:Net.Optifine.Reflect.IFieldLocatorInvoker, AvventuraPokemon")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("net/optifine/reflect/IFieldLocator", DoNotGenerateAcw=true)]
	internal partial class IFieldLocatorInvoker : global::Java.Lang.Object, IFieldLocator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/reflect/IFieldLocator", typeof (IFieldLocatorInvoker));

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

		public static IFieldLocator? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFieldLocator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.reflect.IFieldLocator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFieldLocatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getField;
#pragma warning disable 0169
		static Delegate GetGetFieldHandler ()
		{
			if (cb_getField == null)
				cb_getField = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetField));
			return cb_getField;
		}

		static IntPtr n_GetField (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Reflect.IFieldLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Field);
		}
#pragma warning restore 0169

		IntPtr id_getField;
		public unsafe global::Java.Lang.Reflect.Field? Field {
			get {
				if (id_getField == IntPtr.Zero)
					id_getField = JNIEnv.GetMethodID (class_ref, "getField", "()Ljava/lang/reflect/Field;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getField), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
