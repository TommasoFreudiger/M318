using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Render {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.render']/interface[@name='ICamera']"
	[Register ("net/optifine/render/ICamera", "", "Net.Optifine.Render.ICameraInvoker")]
	public partial interface ICamera : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.render']/interface[@name='ICamera']/method[@name='isBoxInFrustumFully' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("isBoxInFrustumFully", "(DDDDDD)Z", "GetIsBoxInFrustumFully_DDDDDDHandler:Net.Optifine.Render.ICameraInvoker, AvventuraPokemon")]
		bool IsBoxInFrustumFully (double p0, double p1, double p2, double p3, double p4, double p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.render']/interface[@name='ICamera']/method[@name='setCameraPosition' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("setCameraPosition", "(DDD)V", "GetSetCameraPosition_DDDHandler:Net.Optifine.Render.ICameraInvoker, AvventuraPokemon")]
		void SetCameraPosition (double p0, double p1, double p2);

	}

	[global::Android.Runtime.Register ("net/optifine/render/ICamera", DoNotGenerateAcw=true)]
	internal partial class ICameraInvoker : global::Java.Lang.Object, ICamera {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/render/ICamera", typeof (ICameraInvoker));

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

		public static ICamera? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICamera> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.render.ICamera'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_isBoxInFrustumFully_DDDDDD;
#pragma warning disable 0169
		static Delegate GetIsBoxInFrustumFully_DDDDDDHandler ()
		{
			if (cb_isBoxInFrustumFully_DDDDDD == null)
				cb_isBoxInFrustumFully_DDDDDD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDDDDDD_Z (n_IsBoxInFrustumFully_DDDDDD));
			return cb_isBoxInFrustumFully_DDDDDD;
		}

		static bool n_IsBoxInFrustumFully_DDDDDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2, double p3, double p4, double p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Render.ICamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsBoxInFrustumFully (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_isBoxInFrustumFully_DDDDDD;
		public unsafe bool IsBoxInFrustumFully (double p0, double p1, double p2, double p3, double p4, double p5)
		{
			if (id_isBoxInFrustumFully_DDDDDD == IntPtr.Zero)
				id_isBoxInFrustumFully_DDDDDD = JNIEnv.GetMethodID (class_ref, "isBoxInFrustumFully", "(DDDDDD)Z");
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBoxInFrustumFully_DDDDDD, __args);
		}

		static Delegate? cb_setCameraPosition_DDD;
#pragma warning disable 0169
		static Delegate GetSetCameraPosition_DDDHandler ()
		{
			if (cb_setCameraPosition_DDD == null)
				cb_setCameraPosition_DDD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDDD_V (n_SetCameraPosition_DDD));
			return cb_setCameraPosition_DDD;
		}

		static void n_SetCameraPosition_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Render.ICamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetCameraPosition (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setCameraPosition_DDD;
		public unsafe void SetCameraPosition (double p0, double p1, double p2)
		{
			if (id_setCameraPosition_DDD == IntPtr.Zero)
				id_setCameraPosition_DDD = JNIEnv.GetMethodID (class_ref, "setCameraPosition", "(DDD)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraPosition_DDD, __args);
		}

	}
}
