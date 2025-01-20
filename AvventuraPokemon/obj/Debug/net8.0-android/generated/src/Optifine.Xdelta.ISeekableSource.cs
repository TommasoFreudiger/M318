using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Xdelta {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.xdelta']/interface[@name='SeekableSource']"
	[Register ("optifine/xdelta/SeekableSource", "", "Optifine.Xdelta.ISeekableSourceInvoker")]
	public partial interface ISeekableSource : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='SeekableSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Optifine.Xdelta.ISeekableSourceInvoker, AvventuraPokemon")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='SeekableSource']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler:Optifine.Xdelta.ISeekableSourceInvoker, AvventuraPokemon")]
		long Length ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='SeekableSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Optifine.Xdelta.ISeekableSourceInvoker, AvventuraPokemon")]
		int Read (byte[]? p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='SeekableSource']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seek", "(J)V", "GetSeek_JHandler:Optifine.Xdelta.ISeekableSourceInvoker, AvventuraPokemon")]
		void Seek (long p0);

	}

	[global::Android.Runtime.Register ("optifine/xdelta/SeekableSource", DoNotGenerateAcw=true)]
	internal partial class ISeekableSourceInvoker : global::Java.Lang.Object, ISeekableSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/xdelta/SeekableSource", typeof (ISeekableSourceInvoker));

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

		public static ISeekableSource? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISeekableSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.xdelta.SeekableSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISeekableSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Close));
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.ISeekableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate? cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_Length));
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.ISeekableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Length ();
		}
#pragma warning restore 0169

		IntPtr id_length;
		public unsafe long Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_length);
		}

		static Delegate? cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_I (n_Read_arrayBII));
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.ISeekableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe int Read (byte[]? p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate? cb_seek_J;
#pragma warning disable 0169
		static Delegate GetSeek_JHandler ()
		{
			if (cb_seek_J == null)
				cb_seek_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_V (n_Seek_J));
			return cb_seek_J;
		}

		static void n_Seek_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.ISeekableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Seek (p0);
		}
#pragma warning restore 0169

		IntPtr id_seek_J;
		public unsafe void Seek (long p0)
		{
			if (id_seek_J == IntPtr.Zero)
				id_seek_J = JNIEnv.GetMethodID (class_ref, "seek", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek_J, __args);
		}

	}
}
