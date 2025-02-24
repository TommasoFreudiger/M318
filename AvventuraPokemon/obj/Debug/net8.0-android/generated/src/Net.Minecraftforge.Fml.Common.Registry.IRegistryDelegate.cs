using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Fml.Common.Registry {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.fml.common.registry']/interface[@name='RegistryDelegate']"
	[Register ("net/minecraftforge/fml/common/registry/RegistryDelegate", "", "Net.Minecraftforge.Fml.Common.Registry.IRegistryDelegateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IRegistryDelegate : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.fml.common.registry']/interface[@name='RegistryDelegate']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler:Net.Minecraftforge.Fml.Common.Registry.IRegistryDelegateInvoker, AvventuraPokemon")]
		global::Java.Lang.Object? Get ();

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.fml.common.registry']/interface[@name='RegistryDelegate']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Ljava/lang/Class;", "GetTypeHandler:Net.Minecraftforge.Fml.Common.Registry.IRegistryDelegateInvoker, AvventuraPokemon")]
		global::Java.Lang.Class? Type ();

	}

	[global::Android.Runtime.Register ("net/minecraftforge/fml/common/registry/RegistryDelegate", DoNotGenerateAcw=true)]
	internal partial class IRegistryDelegateInvoker : global::Java.Lang.Object, IRegistryDelegate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/fml/common/registry/RegistryDelegate", typeof (IRegistryDelegateInvoker));

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

		public static IRegistryDelegate? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRegistryDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.fml.common.registry.RegistryDelegate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRegistryDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Get));
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Fml.Common.Registry.IRegistryDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object? Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Type));
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Fml.Common.Registry.IRegistryDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		IntPtr id_type;
		public unsafe global::Java.Lang.Class? Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type), JniHandleOwnership.TransferLocalRef);
		}

	}
}
