using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Texture {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.texture']/interface[@name='IBlender']"
	[Register ("net/optifine/texture/IBlender", "", "Net.Optifine.Texture.IBlenderInvoker")]
	public partial interface IBlender : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.texture']/interface[@name='IBlender']/method[@name='blend' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("blend", "(IIII)I", "GetBlend_IIIIHandler:Net.Optifine.Texture.IBlenderInvoker, AvventuraPokemon")]
		int Blend (int p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("net/optifine/texture/IBlender", DoNotGenerateAcw=true)]
	internal partial class IBlenderInvoker : global::Java.Lang.Object, IBlender {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/texture/IBlender", typeof (IBlenderInvoker));

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

		public static IBlender? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBlender> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.texture.IBlender'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBlenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_blend_IIII;
#pragma warning disable 0169
		static Delegate GetBlend_IIIIHandler ()
		{
			if (cb_blend_IIII == null)
				cb_blend_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIII_I (n_Blend_IIII));
			return cb_blend_IIII;
		}

		static int n_Blend_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Texture.IBlender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Blend (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_blend_IIII;
		public unsafe int Blend (int p0, int p1, int p2, int p3)
		{
			if (id_blend_IIII == IntPtr.Zero)
				id_blend_IIII = JNIEnv.GetMethodID (class_ref, "blend", "(IIII)I");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_blend_IIII, __args);
		}

	}
}
