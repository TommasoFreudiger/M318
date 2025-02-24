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

namespace Net.Optifine {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine']/class[@name='Log']"
	[global::Android.Runtime.Register ("net/optifine/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='Log']/field[@name='logDetail']"
		[Register ("logDetail")]
		public static bool LogDetail {
			get {
				const string __id = "logDetail.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/Log", typeof (Log));

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

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine']/class[@name='Log']/constructor[@name='Log' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Log () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='dbg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dbg", "(Ljava/lang/String;)V", "")]
		public static unsafe void Dbg (string? s)
		{
			const string __id = "dbg.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='detail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("detail", "(Ljava/lang/String;)V", "")]
		public static unsafe void Detail (string? s)
		{
			const string __id = "detail.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public static unsafe void Error (string? s)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Error (string? s, global::Java.Lang.Throwable? t)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void InvokeLog (string? s)
		{
			const string __id = "log.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public static unsafe void Warn (string? s)
		{
			const string __id = "warn.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Log']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Warn (string? s, global::Java.Lang.Throwable? t)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				global::System.GC.KeepAlive (t);
			}
		}

	}
}
