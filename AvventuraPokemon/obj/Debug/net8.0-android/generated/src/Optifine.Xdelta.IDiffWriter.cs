using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Optifine.Xdelta {

	// Metadata.xml XPath interface reference: path="/api/package[@name='optifine.xdelta']/interface[@name='DiffWriter']"
	[Register ("optifine/xdelta/DiffWriter", "", "Optifine.Xdelta.IDiffWriterInvoker")]
	public partial interface IDiffWriter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='DiffWriter']/method[@name='addCopy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addCopy", "(II)V", "GetAddCopy_IIHandler:Optifine.Xdelta.IDiffWriterInvoker, AvventuraPokemon")]
		void AddCopy (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='DiffWriter']/method[@name='addData' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("addData", "(B)V", "GetAddData_BHandler:Optifine.Xdelta.IDiffWriterInvoker, AvventuraPokemon")]
		void AddData (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='DiffWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Optifine.Xdelta.IDiffWriterInvoker, AvventuraPokemon")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.xdelta']/interface[@name='DiffWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Optifine.Xdelta.IDiffWriterInvoker, AvventuraPokemon")]
		void Flush ();

	}

	[global::Android.Runtime.Register ("optifine/xdelta/DiffWriter", DoNotGenerateAcw=true)]
	internal partial class IDiffWriterInvoker : global::Java.Lang.Object, IDiffWriter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/xdelta/DiffWriter", typeof (IDiffWriterInvoker));

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

		public static IDiffWriter? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiffWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'optifine.xdelta.DiffWriter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiffWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_addCopy_II;
#pragma warning disable 0169
		static Delegate GetAddCopy_IIHandler ()
		{
			if (cb_addCopy_II == null)
				cb_addCopy_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_AddCopy_II));
			return cb_addCopy_II;
		}

		static void n_AddCopy_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.IDiffWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.AddCopy (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addCopy_II;
		public unsafe void AddCopy (int p0, int p1)
		{
			if (id_addCopy_II == IntPtr.Zero)
				id_addCopy_II = JNIEnv.GetMethodID (class_ref, "addCopy", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCopy_II, __args);
		}

		static Delegate? cb_addData_B;
#pragma warning disable 0169
		static Delegate GetAddData_BHandler ()
		{
			if (cb_addData_B == null)
				cb_addData_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_V (n_AddData_B));
			return cb_addData_B;
		}

		static void n_AddData_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.IDiffWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.AddData (p0);
		}
#pragma warning restore 0169

		IntPtr id_addData_B;
		public unsafe void AddData (sbyte p0)
		{
			if (id_addData_B == IntPtr.Zero)
				id_addData_B = JNIEnv.GetMethodID (class_ref, "addData", "(B)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addData_B, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.IDiffWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Flush));
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Xdelta.IDiffWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

	}
}
