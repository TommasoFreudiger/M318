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

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine']/class[@name='Lang']"
	[global::Android.Runtime.Register ("net/optifine/Lang", DoNotGenerateAcw=true)]
	public partial class Lang : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/Lang", typeof (Lang));

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

		protected Lang (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/constructor[@name='Lang' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Lang () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe string? Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDefault.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? Fancy {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='getFancy' and count(parameter)=0]"
			[Register ("getFancy", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFancy.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? Fast {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='getFast' and count(parameter)=0]"
			[Register ("getFast", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFast.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? Off {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='getOff' and count(parameter)=0]"
			[Register ("getOff", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOff.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? On {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='getOn' and count(parameter)=0]"
			[Register ("getOn", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOn.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? Get (string? key)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? Get (string? key, string? def)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_def = JNIEnv.NewString ((string?)def);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_def);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_def);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='loadLocaleData' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.util.Map']]"
		[Register ("loadLocaleData", "(Ljava/io/InputStream;Ljava/util/Map;)V", "")]
		public static unsafe void LoadLocaleData (global::System.IO.Stream? @is, global::System.Collections.IDictionary? localeProperties)
		{
			const string __id = "loadLocaleData.(Ljava/io/InputStream;Ljava/util/Map;)V";
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			IntPtr native_localeProperties = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (localeProperties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue (native_localeProperties);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
				JNIEnv.DeleteLocalRef (native_localeProperties);
				global::System.GC.KeepAlive (@is);
				global::System.GC.KeepAlive (localeProperties);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='Lang']/method[@name='resourcesReloaded' and count(parameter)=0]"
		[Register ("resourcesReloaded", "()V", "")]
		public static unsafe void ResourcesReloaded ()
		{
			const string __id = "resourcesReloaded.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
