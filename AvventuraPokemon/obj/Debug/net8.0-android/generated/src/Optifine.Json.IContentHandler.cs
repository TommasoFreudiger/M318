using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Json {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']"
	[Register ("optifine/json/ContentHandler", "", "Optifine.Json.IContentHandlerInvoker")]
	public partial interface IContentHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='endArray' and count(parameter)=0]"
		[Register ("endArray", "()Z", "GetEndArrayHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool EndArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='endJSON' and count(parameter)=0]"
		[Register ("endJSON", "()V", "GetEndJSONHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		void EndJSON ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='endObject' and count(parameter)=0]"
		[Register ("endObject", "()Z", "GetEndObjectHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool EndObject ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='endObjectEntry' and count(parameter)=0]"
		[Register ("endObjectEntry", "()Z", "GetEndObjectEntryHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool EndObjectEntry ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='primitive' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("primitive", "(Ljava/lang/Object;)Z", "GetPrimitive_Ljava_lang_Object_Handler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool Primitive (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='startArray' and count(parameter)=0]"
		[Register ("startArray", "()Z", "GetStartArrayHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool StartArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='startJSON' and count(parameter)=0]"
		[Register ("startJSON", "()V", "GetStartJSONHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		void StartJSON ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='startObject' and count(parameter)=0]"
		[Register ("startObject", "()Z", "GetStartObjectHandler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool StartObject ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/interface[@name='ContentHandler']/method[@name='startObjectEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startObjectEntry", "(Ljava/lang/String;)Z", "GetStartObjectEntry_Ljava_lang_String_Handler:Optifine.Json.IContentHandlerInvoker, AvventuraPokemon")]
		bool StartObjectEntry (string? p0);

	}

	[global::Android.Runtime.Register ("optifine/json/ContentHandler", DoNotGenerateAcw=true)]
	internal partial class IContentHandlerInvoker : global::Java.Lang.Object, IContentHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/ContentHandler", typeof (IContentHandlerInvoker));

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

		public static IContentHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContentHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.json.ContentHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContentHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_endArray;
#pragma warning disable 0169
		static Delegate GetEndArrayHandler ()
		{
			if (cb_endArray == null)
				cb_endArray = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EndArray));
			return cb_endArray;
		}

		static bool n_EndArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EndArray ();
		}
#pragma warning restore 0169

		IntPtr id_endArray;
		public unsafe bool EndArray ()
		{
			if (id_endArray == IntPtr.Zero)
				id_endArray = JNIEnv.GetMethodID (class_ref, "endArray", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_endArray);
		}

		static Delegate? cb_endJSON;
#pragma warning disable 0169
		static Delegate GetEndJSONHandler ()
		{
			if (cb_endJSON == null)
				cb_endJSON = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_EndJSON));
			return cb_endJSON;
		}

		static void n_EndJSON (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.EndJSON ();
		}
#pragma warning restore 0169

		IntPtr id_endJSON;
		public unsafe void EndJSON ()
		{
			if (id_endJSON == IntPtr.Zero)
				id_endJSON = JNIEnv.GetMethodID (class_ref, "endJSON", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endJSON);
		}

		static Delegate? cb_endObject;
#pragma warning disable 0169
		static Delegate GetEndObjectHandler ()
		{
			if (cb_endObject == null)
				cb_endObject = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EndObject));
			return cb_endObject;
		}

		static bool n_EndObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EndObject ();
		}
#pragma warning restore 0169

		IntPtr id_endObject;
		public unsafe bool EndObject ()
		{
			if (id_endObject == IntPtr.Zero)
				id_endObject = JNIEnv.GetMethodID (class_ref, "endObject", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_endObject);
		}

		static Delegate? cb_endObjectEntry;
#pragma warning disable 0169
		static Delegate GetEndObjectEntryHandler ()
		{
			if (cb_endObjectEntry == null)
				cb_endObjectEntry = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_EndObjectEntry));
			return cb_endObjectEntry;
		}

		static bool n_EndObjectEntry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.EndObjectEntry ();
		}
#pragma warning restore 0169

		IntPtr id_endObjectEntry;
		public unsafe bool EndObjectEntry ()
		{
			if (id_endObjectEntry == IntPtr.Zero)
				id_endObjectEntry = JNIEnv.GetMethodID (class_ref, "endObjectEntry", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_endObjectEntry);
		}

		static Delegate? cb_primitive_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPrimitive_Ljava_lang_Object_Handler ()
		{
			if (cb_primitive_Ljava_lang_Object_ == null)
				cb_primitive_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_Primitive_Ljava_lang_Object_));
			return cb_primitive_Ljava_lang_Object_;
		}

		static bool n_Primitive_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Primitive (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_primitive_Ljava_lang_Object_;
		public unsafe bool Primitive (global::Java.Lang.Object? p0)
		{
			if (id_primitive_Ljava_lang_Object_ == IntPtr.Zero)
				id_primitive_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "primitive", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_primitive_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate? cb_startArray;
#pragma warning disable 0169
		static Delegate GetStartArrayHandler ()
		{
			if (cb_startArray == null)
				cb_startArray = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_StartArray));
			return cb_startArray;
		}

		static bool n_StartArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StartArray ();
		}
#pragma warning restore 0169

		IntPtr id_startArray;
		public unsafe bool StartArray ()
		{
			if (id_startArray == IntPtr.Zero)
				id_startArray = JNIEnv.GetMethodID (class_ref, "startArray", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startArray);
		}

		static Delegate? cb_startJSON;
#pragma warning disable 0169
		static Delegate GetStartJSONHandler ()
		{
			if (cb_startJSON == null)
				cb_startJSON = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StartJSON));
			return cb_startJSON;
		}

		static void n_StartJSON (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.StartJSON ();
		}
#pragma warning restore 0169

		IntPtr id_startJSON;
		public unsafe void StartJSON ()
		{
			if (id_startJSON == IntPtr.Zero)
				id_startJSON = JNIEnv.GetMethodID (class_ref, "startJSON", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startJSON);
		}

		static Delegate? cb_startObject;
#pragma warning disable 0169
		static Delegate GetStartObjectHandler ()
		{
			if (cb_startObject == null)
				cb_startObject = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_StartObject));
			return cb_startObject;
		}

		static bool n_StartObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.StartObject ();
		}
#pragma warning restore 0169

		IntPtr id_startObject;
		public unsafe bool StartObject ()
		{
			if (id_startObject == IntPtr.Zero)
				id_startObject = JNIEnv.GetMethodID (class_ref, "startObject", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startObject);
		}

		static Delegate? cb_startObjectEntry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartObjectEntry_Ljava_lang_String_Handler ()
		{
			if (cb_startObjectEntry_Ljava_lang_String_ == null)
				cb_startObjectEntry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_StartObjectEntry_Ljava_lang_String_));
			return cb_startObjectEntry_Ljava_lang_String_;
		}

		static bool n_StartObjectEntry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartObjectEntry (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startObjectEntry_Ljava_lang_String_;
		public unsafe bool StartObjectEntry (string? p0)
		{
			if (id_startObjectEntry_Ljava_lang_String_ == IntPtr.Zero)
				id_startObjectEntry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startObjectEntry", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startObjectEntry_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
