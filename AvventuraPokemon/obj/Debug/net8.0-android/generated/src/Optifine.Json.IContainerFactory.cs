using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Json {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.json']/interface[@name='ContainerFactory']"
	[Register ("optifine/json/ContainerFactory", "", "Optifine.Json.IContainerFactoryInvoker")]
	public partial interface IContainerFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContainerFactory']/method[@name='creatArrayContainer' and count(parameter)=0]"
		[Register ("creatArrayContainer", "()Ljava/util/List;", "GetCreatArrayContainerHandler:Optifine.Json.IContainerFactoryInvoker, AvventuraPokemon")]
		global::System.Collections.IList? CreatArrayContainer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContainerFactory']/method[@name='createObjectContainer' and count(parameter)=0]"
		[Register ("createObjectContainer", "()Ljava/util/Map;", "GetCreateObjectContainerHandler:Optifine.Json.IContainerFactoryInvoker, AvventuraPokemon")]
		global::System.Collections.IDictionary? CreateObjectContainer ();

	}

	[global::Android.Runtime.Register ("optifine/json/ContainerFactory", DoNotGenerateAcw=true)]
	internal partial class IContainerFactoryInvoker : global::Java.Lang.Object, IContainerFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/ContainerFactory", typeof (IContainerFactoryInvoker));

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

		public static IContainerFactory? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContainerFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.json.ContainerFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContainerFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_creatArrayContainer;
#pragma warning disable 0169
		static Delegate GetCreatArrayContainerHandler ()
		{
			if (cb_creatArrayContainer == null)
				cb_creatArrayContainer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_CreatArrayContainer));
			return cb_creatArrayContainer;
		}

		static IntPtr n_CreatArrayContainer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContainerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.CreatArrayContainer ());
		}
#pragma warning restore 0169

		IntPtr id_creatArrayContainer;
		public unsafe global::System.Collections.IList? CreatArrayContainer ()
		{
			if (id_creatArrayContainer == IntPtr.Zero)
				id_creatArrayContainer = JNIEnv.GetMethodID (class_ref, "creatArrayContainer", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_creatArrayContainer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_createObjectContainer;
#pragma warning disable 0169
		static Delegate GetCreateObjectContainerHandler ()
		{
			if (cb_createObjectContainer == null)
				cb_createObjectContainer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_CreateObjectContainer));
			return cb_createObjectContainer;
		}

		static IntPtr n_CreateObjectContainer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContainerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.CreateObjectContainer ());
		}
#pragma warning restore 0169

		IntPtr id_createObjectContainer;
		public unsafe global::System.Collections.IDictionary? CreateObjectContainer ()
		{
			if (id_createObjectContainer == IntPtr.Zero)
				id_createObjectContainer = JNIEnv.GetMethodID (class_ref, "createObjectContainer", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createObjectContainer), JniHandleOwnership.TransferLocalRef);
		}

	}
}
