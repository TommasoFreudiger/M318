using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine']/interface[@name='IRandomEntity']"
	[Register ("net/optifine/IRandomEntity", "", "Net.Optifine.IRandomEntityInvoker")]
	public partial interface IRandomEntity : IJavaObject, IJavaPeerable {
		int Health {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='IRandomEntity']/method[@name='getHealth' and count(parameter)=0]"
			[Register ("getHealth", "()I", "GetGetHealthHandler:Net.Optifine.IRandomEntityInvoker, AvventuraPokemon")]
			get; 
		}

		int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='IRandomEntity']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler:Net.Optifine.IRandomEntityInvoker, AvventuraPokemon")]
			get; 
		}

		int MaxHealth {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='IRandomEntity']/method[@name='getMaxHealth' and count(parameter)=0]"
			[Register ("getMaxHealth", "()I", "GetGetMaxHealthHandler:Net.Optifine.IRandomEntityInvoker, AvventuraPokemon")]
			get; 
		}

		string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='IRandomEntity']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Net.Optifine.IRandomEntityInvoker, AvventuraPokemon")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("net/optifine/IRandomEntity", DoNotGenerateAcw=true)]
	internal partial class IRandomEntityInvoker : global::Java.Lang.Object, IRandomEntity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/IRandomEntity", typeof (IRandomEntityInvoker));

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

		public static IRandomEntity? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRandomEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.IRandomEntity'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRandomEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getHealth;
#pragma warning disable 0169
		static Delegate GetGetHealthHandler ()
		{
			if (cb_getHealth == null)
				cb_getHealth = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetHealth));
			return cb_getHealth;
		}

		static int n_GetHealth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Health;
		}
#pragma warning restore 0169

		IntPtr id_getHealth;
		public unsafe int Health {
			get {
				if (id_getHealth == IntPtr.Zero)
					id_getHealth = JNIEnv.GetMethodID (class_ref, "getHealth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHealth);
			}
		}

		static Delegate? cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetId));
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Id;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe int Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
			}
		}

		static Delegate? cb_getMaxHealth;
#pragma warning disable 0169
		static Delegate GetGetMaxHealthHandler ()
		{
			if (cb_getMaxHealth == null)
				cb_getMaxHealth = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetMaxHealth));
			return cb_getMaxHealth;
		}

		static int n_GetMaxHealth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.MaxHealth;
		}
#pragma warning restore 0169

		IntPtr id_getMaxHealth;
		public unsafe int MaxHealth {
			get {
				if (id_getMaxHealth == IntPtr.Zero)
					id_getMaxHealth = JNIEnv.GetMethodID (class_ref, "getMaxHealth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxHealth);
			}
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string? Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
