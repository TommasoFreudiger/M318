using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.http']/interface[@name='HttpListener']"
	[Register ("net/optifine/http/HttpListener", "", "Net.Optifine.Http.IHttpListenerInvoker")]
	public partial interface IHttpListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.http']/interface[@name='HttpListener']/method[@name='failed' and count(parameter)=2 and parameter[1][@type='net.optifine.http.HttpRequest'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("failed", "(Lnet/optifine/http/HttpRequest;Ljava/lang/Exception;)V", "GetFailed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_Handler:Net.Optifine.Http.IHttpListenerInvoker, AvventuraPokemon")]
		void Failed (global::Net.Optifine.Http.HttpRequest? p0, global::Java.Lang.Exception? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.http']/interface[@name='HttpListener']/method[@name='finished' and count(parameter)=2 and parameter[1][@type='net.optifine.http.HttpRequest'] and parameter[2][@type='net.optifine.http.HttpResponse']]"
		[Register ("finished", "(Lnet/optifine/http/HttpRequest;Lnet/optifine/http/HttpResponse;)V", "GetFinished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_Handler:Net.Optifine.Http.IHttpListenerInvoker, AvventuraPokemon")]
		void Finished (global::Net.Optifine.Http.HttpRequest? p0, global::Net.Optifine.Http.HttpResponse? p1);

	}

	[global::Android.Runtime.Register ("net/optifine/http/HttpListener", DoNotGenerateAcw=true)]
	internal partial class IHttpListenerInvoker : global::Java.Lang.Object, IHttpListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/http/HttpListener", typeof (IHttpListenerInvoker));

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

		public static IHttpListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.http.HttpListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetFailed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_Handler ()
		{
			if (cb_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_ == null)
				cb_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_));
			return cb_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_;
		}

		static void n_Failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.IHttpListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.HttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Failed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_;
		public unsafe void Failed (global::Net.Optifine.Http.HttpRequest? p0, global::Java.Lang.Exception? p1)
		{
			if (id_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_ == IntPtr.Zero)
				id_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "failed", "(Lnet/optifine/http/HttpRequest;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failed_Lnet_optifine_http_HttpRequest_Ljava_lang_Exception_, __args);
		}

		static Delegate? cb_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetFinished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_Handler ()
		{
			if (cb_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_ == null)
				cb_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_));
			return cb_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_;
		}

		static void n_Finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.IHttpListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.HttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Net.Optifine.Http.HttpResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Finished (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_;
		public unsafe void Finished (global::Net.Optifine.Http.HttpRequest? p0, global::Net.Optifine.Http.HttpResponse? p1)
		{
			if (id_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_ == IntPtr.Zero)
				id_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "finished", "(Lnet/optifine/http/HttpRequest;Lnet/optifine/http/HttpResponse;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finished_Lnet_optifine_http_HttpRequest_Lnet_optifine_http_HttpResponse_, __args);
		}

	}

	// event args for net.optifine.http.HttpListener.failed
	public partial class FailedEventArgs : global::System.EventArgs {
		public FailedEventArgs (global::Net.Optifine.Http.HttpRequest? p0, global::Java.Lang.Exception? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Net.Optifine.Http.HttpRequest? p0;

		public global::Net.Optifine.Http.HttpRequest? P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception? p1;

		public global::Java.Lang.Exception? P1 {
			get { return p1; }
		}

	}

	// event args for net.optifine.http.HttpListener.finished
	public partial class FinishedEventArgs : global::System.EventArgs {
		public FinishedEventArgs (global::Net.Optifine.Http.HttpRequest? p0, global::Net.Optifine.Http.HttpResponse? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Net.Optifine.Http.HttpRequest? p0;

		public global::Net.Optifine.Http.HttpRequest? P0 {
			get { return p0; }
		}

		global::Net.Optifine.Http.HttpResponse? p1;

		public global::Net.Optifine.Http.HttpResponse? P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/net/optifine/http/HttpListenerImplementor")]
	internal sealed partial class IHttpListenerImplementor : global::Java.Lang.Object, IHttpListener {

		object? sender;

		public unsafe IHttpListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<FailedEventArgs>? FailedHandler;
		#pragma warning restore 0649

		public void Failed (global::Net.Optifine.Http.HttpRequest? p0, global::Java.Lang.Exception? p1)
		{
			var __h = FailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<FinishedEventArgs>? FinishedHandler;
		#pragma warning restore 0649

		public void Finished (global::Net.Optifine.Http.HttpRequest? p0, global::Net.Optifine.Http.HttpResponse? p1)
		{
			var __h = FinishedHandler;
			if (__h != null)
				__h (sender, new FinishedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IHttpListenerImplementor value)
		{
			return value.FailedHandler == null && value.FinishedHandler == null;
		}

	}
}
