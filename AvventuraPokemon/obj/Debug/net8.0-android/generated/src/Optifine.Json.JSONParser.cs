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

namespace Optifine.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']"
	[global::Android.Runtime.Register ("optifine/json/JSONParser", DoNotGenerateAcw=true)]
	public partial class JSONParser : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_END']"
		[Register ("S_END")]
		public const int SEnd = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_INIT']"
		[Register ("S_INIT")]
		public const int SInit = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_IN_ARRAY']"
		[Register ("S_IN_ARRAY")]
		public const int SInArray = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_IN_ERROR']"
		[Register ("S_IN_ERROR")]
		public const int SInError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_IN_FINISHED_VALUE']"
		[Register ("S_IN_FINISHED_VALUE")]
		public const int SInFinishedValue = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_IN_OBJECT']"
		[Register ("S_IN_OBJECT")]
		public const int SInObject = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_IN_PAIR_VALUE']"
		[Register ("S_IN_PAIR_VALUE")]
		public const int SInPairValue = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/field[@name='S_PASSED_PAIR_KEY']"
		[Register ("S_PASSED_PAIR_KEY")]
		public const int SPassedPairKey = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/JSONParser", typeof (JSONParser));

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

		protected JSONParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/constructor[@name='JSONParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JSONParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetPosition));
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Position;
		}
#pragma warning restore 0169

		public virtual unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_parse_Ljava_io_Reader_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_Reader_Handler ()
		{
			if (cb_parse_Ljava_io_Reader_ == null)
				cb_parse_Ljava_io_Reader_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Parse_Ljava_io_Reader_));
			return cb_parse_Ljava_io_Reader_;
		}

		static IntPtr n_Parse_Ljava_io_Reader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @in = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (@in));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("parse", "(Ljava/io/Reader;)Ljava/lang/Object;", "GetParse_Ljava_io_Reader_Handler")]
		public virtual unsafe global::Java.Lang.Object? Parse (global::Java.IO.Reader? @in)
		{
			const string __id = "parse.(Ljava/io/Reader;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate? cb_parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_Reader_Loptifine_json_ContainerFactory_Handler ()
		{
			if (cb_parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_ == null)
				cb_parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_Parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_));
			return cb_parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_;
		}

		static IntPtr n_Parse_Ljava_io_Reader_Loptifine_json_ContainerFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_containerFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @in = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native__in, JniHandleOwnership.DoNotTransfer);
			var containerFactory = (global::Optifine.Json.IContainerFactory?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContainerFactory> (native_containerFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (@in, containerFactory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='optifine.json.ContainerFactory']]"
		[Register ("parse", "(Ljava/io/Reader;Loptifine/json/ContainerFactory;)Ljava/lang/Object;", "GetParse_Ljava_io_Reader_Loptifine_json_ContainerFactory_Handler")]
		public virtual unsafe global::Java.Lang.Object? Parse (global::Java.IO.Reader? @in, global::Optifine.Json.IContainerFactory? containerFactory)
		{
			const string __id = "parse.(Ljava/io/Reader;Loptifine/json/ContainerFactory;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				__args [1] = new JniArgumentValue ((containerFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) containerFactory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@in);
				global::System.GC.KeepAlive (containerFactory);
			}
		}

		static Delegate? cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_Reader_Loptifine_json_ContentHandler_Handler ()
		{
			if (cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_ == null)
				cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Parse_Ljava_io_Reader_Loptifine_json_ContentHandler_));
			return cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_;
		}

		static void n_Parse_Ljava_io_Reader_Loptifine_json_ContentHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_contentHandler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @in = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native__in, JniHandleOwnership.DoNotTransfer);
			var contentHandler = (global::Optifine.Json.IContentHandler?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (native_contentHandler, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@in, contentHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='optifine.json.ContentHandler']]"
		[Register ("parse", "(Ljava/io/Reader;Loptifine/json/ContentHandler;)V", "GetParse_Ljava_io_Reader_Loptifine_json_ContentHandler_Handler")]
		public virtual unsafe void Parse (global::Java.IO.Reader? @in, global::Optifine.Json.IContentHandler? contentHandler)
		{
			const string __id = "parse.(Ljava/io/Reader;Loptifine/json/ContentHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				__args [1] = new JniArgumentValue ((contentHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
				global::System.GC.KeepAlive (contentHandler);
			}
		}

		static Delegate? cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_io_Reader_Loptifine_json_ContentHandler_ZHandler ()
		{
			if (cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z == null)
				cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZ_V (n_Parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z));
			return cb_parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z;
		}

		static void n_Parse_Ljava_io_Reader_Loptifine_json_ContentHandler_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_contentHandler, bool isResume)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @in = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native__in, JniHandleOwnership.DoNotTransfer);
			var contentHandler = (global::Optifine.Json.IContentHandler?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (native_contentHandler, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@in, contentHandler, isResume);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='optifine.json.ContentHandler'] and parameter[3][@type='boolean']]"
		[Register ("parse", "(Ljava/io/Reader;Loptifine/json/ContentHandler;Z)V", "GetParse_Ljava_io_Reader_Loptifine_json_ContentHandler_ZHandler")]
		public virtual unsafe void Parse (global::Java.IO.Reader? @in, global::Optifine.Json.IContentHandler? contentHandler, bool isResume)
		{
			const string __id = "parse.(Ljava/io/Reader;Loptifine/json/ContentHandler;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				__args [1] = new JniArgumentValue ((contentHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentHandler).Handle);
				__args [2] = new JniArgumentValue (isResume);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
				global::System.GC.KeepAlive (contentHandler);
			}
		}

		static Delegate? cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Parse_Ljava_lang_String_));
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (s));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Ljava/lang/Object;", "GetParse_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object? Parse (string? s)
		{
			const string __id = "parse.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate? cb_parse_Ljava_lang_String_Loptifine_json_ContainerFactory_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Loptifine_json_ContainerFactory_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Loptifine_json_ContainerFactory_ == null)
				cb_parse_Ljava_lang_String_Loptifine_json_ContainerFactory_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_Parse_Ljava_lang_String_Loptifine_json_ContainerFactory_));
			return cb_parse_Ljava_lang_String_Loptifine_json_ContainerFactory_;
		}

		static IntPtr n_Parse_Ljava_lang_String_Loptifine_json_ContainerFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_containerFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var containerFactory = (global::Optifine.Json.IContainerFactory?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContainerFactory> (native_containerFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (s, containerFactory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='optifine.json.ContainerFactory']]"
		[Register ("parse", "(Ljava/lang/String;Loptifine/json/ContainerFactory;)Ljava/lang/Object;", "GetParse_Ljava_lang_String_Loptifine_json_ContainerFactory_Handler")]
		public virtual unsafe global::Java.Lang.Object? Parse (string? s, global::Optifine.Json.IContainerFactory? containerFactory)
		{
			const string __id = "parse.(Ljava/lang/String;Loptifine/json/ContainerFactory;)Ljava/lang/Object;";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue ((containerFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) containerFactory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (containerFactory);
			}
		}

		static Delegate? cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Loptifine_json_ContentHandler_Handler ()
		{
			if (cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_ == null)
				cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Parse_Ljava_lang_String_Loptifine_json_ContentHandler_));
			return cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_;
		}

		static void n_Parse_Ljava_lang_String_Loptifine_json_ContentHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_contentHandler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var contentHandler = (global::Optifine.Json.IContentHandler?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (native_contentHandler, JniHandleOwnership.DoNotTransfer);
			__this.Parse (s, contentHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='optifine.json.ContentHandler']]"
		[Register ("parse", "(Ljava/lang/String;Loptifine/json/ContentHandler;)V", "GetParse_Ljava_lang_String_Loptifine_json_ContentHandler_Handler")]
		public virtual unsafe void Parse (string? s, global::Optifine.Json.IContentHandler? contentHandler)
		{
			const string __id = "parse.(Ljava/lang/String;Loptifine/json/ContentHandler;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue ((contentHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (contentHandler);
			}
		}

		static Delegate? cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Loptifine_json_ContentHandler_ZHandler ()
		{
			if (cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z == null)
				cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZ_V (n_Parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z));
			return cb_parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z;
		}

		static void n_Parse_Ljava_lang_String_Loptifine_json_ContentHandler_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_contentHandler, bool isResume)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var contentHandler = (global::Optifine.Json.IContentHandler?)global::Java.Lang.Object.GetObject<global::Optifine.Json.IContentHandler> (native_contentHandler, JniHandleOwnership.DoNotTransfer);
			__this.Parse (s, contentHandler, isResume);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='optifine.json.ContentHandler'] and parameter[3][@type='boolean']]"
		[Register ("parse", "(Ljava/lang/String;Loptifine/json/ContentHandler;Z)V", "GetParse_Ljava_lang_String_Loptifine_json_ContentHandler_ZHandler")]
		public virtual unsafe void Parse (string? s, global::Optifine.Json.IContentHandler? contentHandler, bool isResume)
		{
			const string __id = "parse.(Ljava/lang/String;Loptifine/json/ContentHandler;Z)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue ((contentHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentHandler).Handle);
				__args [2] = new JniArgumentValue (isResume);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (contentHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='parseDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseDate", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date? ParseDate (string? input)
		{
			const string __id = "parseDate.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_input = JNIEnv.NewString ((string?)input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate? cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Reset));
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_reset_Ljava_io_Reader_;
#pragma warning disable 0169
		static Delegate GetReset_Ljava_io_Reader_Handler ()
		{
			if (cb_reset_Ljava_io_Reader_ == null)
				cb_reset_Ljava_io_Reader_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Reset_Ljava_io_Reader_));
			return cb_reset_Ljava_io_Reader_;
		}

		static void n_Reset_Ljava_io_Reader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @in = global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Reset (@in);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONParser']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("reset", "(Ljava/io/Reader;)V", "GetReset_Ljava_io_Reader_Handler")]
		public virtual unsafe void Reset (global::Java.IO.Reader? @in)
		{
			const string __id = "reset.(Ljava/io/Reader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
			}
		}

	}
}
