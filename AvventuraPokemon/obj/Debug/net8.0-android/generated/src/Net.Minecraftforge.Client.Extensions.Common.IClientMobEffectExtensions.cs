using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Client.Extensions.Common {

	[Register ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions' type. This class will be removed in a future release.")]
	public abstract class ClientMobEffectExtensions : Java.Lang.Object {
		internal ClientMobEffectExtensions ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientMobEffectExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		[global::System.Obsolete (@"Use 'Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions.Dummy'. This class will be removed in a future release.")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientMobEffectExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", typeof (ClientMobEffectExtensions));

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientMobEffectExtensions']"
	[Register ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", "", "Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensionsInvoker")]
	public partial interface IClientMobEffectExtensions : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", typeof (IClientMobEffectExtensions), isInterface: true);


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientMobEffectExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientMobEffectExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientMobEffectExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

	}

	[global::Android.Runtime.Register ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", DoNotGenerateAcw=true)]
	internal partial class IClientMobEffectExtensionsInvoker : global::Java.Lang.Object, IClientMobEffectExtensions {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientMobEffectExtensions", typeof (IClientMobEffectExtensionsInvoker));

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

		public static IClientMobEffectExtensions? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClientMobEffectExtensions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.client.extensions.common.IClientMobEffectExtensions'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClientMobEffectExtensionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
