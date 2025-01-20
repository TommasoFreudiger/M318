using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.http']/interface[@name='IFileDownloadListener']"
	[Register ("net/optifine/http/IFileDownloadListener", "", "Net.Optifine.Http.IFileDownloadListenerInvoker")]
	public partial interface IFileDownloadListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.http']/interface[@name='IFileDownloadListener']/method[@name='fileDownloadFinished' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("fileDownloadFinished", "(Ljava/lang/String;[BLjava/lang/Throwable;)V", "GetFileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_Handler:Net.Optifine.Http.IFileDownloadListenerInvoker, AvventuraPokemon")]
		void FileDownloadFinished (string? p0, byte[]? p1, global::Java.Lang.Throwable? p2);

	}

	[global::Android.Runtime.Register ("net/optifine/http/IFileDownloadListener", DoNotGenerateAcw=true)]
	internal partial class IFileDownloadListenerInvoker : global::Java.Lang.Object, IFileDownloadListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/http/IFileDownloadListener", typeof (IFileDownloadListenerInvoker));

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

		public static IFileDownloadListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileDownloadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.http.IFileDownloadListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileDownloadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_Handler ()
		{
			if (cb_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_ == null)
				cb_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_FileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_));
			return cb_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_;
		}

		static void n_FileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.IFileDownloadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.FileDownloadFinished (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_;
		public unsafe void FileDownloadFinished (string? p0, byte[]? p1, global::Java.Lang.Throwable? p2)
		{
			if (id_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_ == IntPtr.Zero)
				id_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "fileDownloadFinished", "(Ljava/lang/String;[BLjava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fileDownloadFinished_Ljava_lang_String_arrayBLjava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for net.optifine.http.IFileDownloadListener.fileDownloadFinished
	public partial class FileDownloadEventArgs : global::System.EventArgs {
		public FileDownloadEventArgs (string? p0, byte[]? p1, global::Java.Lang.Throwable? p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		byte[]? p1;

		public byte[]? P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable? p2;

		public global::Java.Lang.Throwable? P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/net/optifine/http/IFileDownloadListenerImplementor")]
	internal sealed partial class IFileDownloadListenerImplementor : global::Java.Lang.Object, IFileDownloadListener {

		object? sender;

		public unsafe IFileDownloadListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<FileDownloadEventArgs>? Handler;
		#pragma warning restore 0649

		public void FileDownloadFinished (string? p0, byte[]? p1, global::Java.Lang.Throwable? p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FileDownloadEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IFileDownloadListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
