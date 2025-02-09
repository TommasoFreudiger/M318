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

	// Metadata.xml XPath class reference: path="/api/package[@name='optifine.json']/class[@name='JSONWriter']"
	[global::Android.Runtime.Register ("optifine/json/JSONWriter", DoNotGenerateAcw=true)]
	public partial class JSONWriter : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/JSONWriter", typeof (JSONWriter));

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

		protected JSONWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='JSONWriter']/constructor[@name='JSONWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe JSONWriter (global::Java.IO.Writer? writer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='JSONWriter']/constructor[@name='JSONWriter' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/Writer;I)V", "")]
		public unsafe JSONWriter (global::Java.IO.Writer? writer, int indentStep) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (indentStep);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='JSONWriter']/constructor[@name='JSONWriter' and count(parameter)=3 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/Writer;II)V", "")]
		public unsafe JSONWriter (global::Java.IO.Writer? writer, int indentStep, int indent) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/Writer;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				__args [1] = new JniArgumentValue (indentStep);
				__args [2] = new JniArgumentValue (indent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (writer);
			}
		}

		static Delegate? cb_writeObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWriteObject_Ljava_lang_Object_Handler ()
		{
			if (cb_writeObject_Ljava_lang_Object_ == null)
				cb_writeObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_WriteObject_Ljava_lang_Object_));
			return cb_writeObject_Ljava_lang_Object_;
		}

		static void n_WriteObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.JSONWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.WriteObject (obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='JSONWriter']/method[@name='writeObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("writeObject", "(Ljava/lang/Object;)V", "GetWriteObject_Ljava_lang_Object_Handler")]
		public virtual unsafe void WriteObject (global::Java.Lang.Object? obj)
		{
			const string __id = "writeObject.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
