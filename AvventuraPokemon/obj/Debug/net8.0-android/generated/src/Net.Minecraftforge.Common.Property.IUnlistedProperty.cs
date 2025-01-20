using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Common.Property {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.common.property']/interface[@name='IUnlistedProperty']"
	[Register ("net/minecraftforge/common/property/IUnlistedProperty", "", "Net.Minecraftforge.Common.Property.IUnlistedPropertyInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public partial interface IUnlistedProperty : IJavaObject, IJavaPeerable {
		string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.property']/interface[@name='IUnlistedProperty']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Net.Minecraftforge.Common.Property.IUnlistedPropertyInvoker, AvventuraPokemon")]
			get; 
		}

		global::Java.Lang.Class? Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.property']/interface[@name='IUnlistedProperty']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler:Net.Minecraftforge.Common.Property.IUnlistedPropertyInvoker, AvventuraPokemon")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.property']/interface[@name='IUnlistedProperty']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("isValid", "(Ljava/lang/Object;)Z", "GetIsValid_Ljava_lang_Object_Handler:Net.Minecraftforge.Common.Property.IUnlistedPropertyInvoker, AvventuraPokemon")]
		bool IsValid (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.property']/interface[@name='IUnlistedProperty']/method[@name='valueToString' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("valueToString", "(Ljava/lang/Object;)Ljava/lang/String;", "GetValueToString_Ljava_lang_Object_Handler:Net.Minecraftforge.Common.Property.IUnlistedPropertyInvoker, AvventuraPokemon")]
		string? ValueToString (global::Java.Lang.Object? p0);

	}

	[global::Android.Runtime.Register ("net/minecraftforge/common/property/IUnlistedProperty", DoNotGenerateAcw=true)]
	internal partial class IUnlistedPropertyInvoker : global::Java.Lang.Object, IUnlistedProperty {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/common/property/IUnlistedProperty", typeof (IUnlistedPropertyInvoker));

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

		public static IUnlistedProperty? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnlistedProperty> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.common.property.IUnlistedProperty'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnlistedPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Property.IUnlistedProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetType));
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Property.IUnlistedProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Java.Lang.Class? Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_isValid_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsValid_Ljava_lang_Object_Handler ()
		{
			if (cb_isValid_Ljava_lang_Object_ == null)
				cb_isValid_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsValid_Ljava_lang_Object_));
			return cb_isValid_Ljava_lang_Object_;
		}

		static bool n_IsValid_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Property.IUnlistedProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsValid (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isValid_Ljava_lang_Object_;
		public unsafe bool IsValid (global::Java.Lang.Object? p0)
		{
			if (id_isValid_Ljava_lang_Object_ == IntPtr.Zero)
				id_isValid_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isValid", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_valueToString_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetValueToString_Ljava_lang_Object_Handler ()
		{
			if (cb_valueToString_Ljava_lang_Object_ == null)
				cb_valueToString_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_ValueToString_Ljava_lang_Object_));
			return cb_valueToString_Ljava_lang_Object_;
		}

		static IntPtr n_ValueToString_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Property.IUnlistedProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ValueToString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_valueToString_Ljava_lang_Object_;
		public unsafe string? ValueToString (global::Java.Lang.Object? p0)
		{
			if (id_valueToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_valueToString_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "valueToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_valueToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
