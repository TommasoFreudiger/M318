using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.reflect']/interface[@name='IResolvable']"
	[Register ("net/optifine/reflect/IResolvable", "", "Net.Optifine.Reflect.IResolvableInvoker")]
	public partial interface IResolvable : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.reflect']/interface[@name='IResolvable']/method[@name='resolve' and count(parameter)=0]"
		[Register ("resolve", "()V", "GetResolveHandler:Net.Optifine.Reflect.IResolvableInvoker, AvventuraPokemon")]
		void Resolve ();

	}

	[global::Android.Runtime.Register ("net/optifine/reflect/IResolvable", DoNotGenerateAcw=true)]
	internal partial class IResolvableInvoker : global::Java.Lang.Object, IResolvable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/reflect/IResolvable", typeof (IResolvableInvoker));

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

		public static IResolvable? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResolvable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.reflect.IResolvable'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResolvableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_resolve;
#pragma warning disable 0169
		static Delegate GetResolveHandler ()
		{
			if (cb_resolve == null)
				cb_resolve = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Resolve));
			return cb_resolve;
		}

		static void n_Resolve (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Reflect.IResolvable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Resolve ();
		}
#pragma warning restore 0169

		IntPtr id_resolve;
		public unsafe void Resolve ()
		{
			if (id_resolve == IntPtr.Zero)
				id_resolve = JNIEnv.GetMethodID (class_ref, "resolve", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resolve);
		}

	}
}
