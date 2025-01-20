using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Client.Extensions.Common {

	[Register ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions' type. This class will be removed in a future release.")]
	public abstract class ClientFluidTypeExtensions : Java.Lang.Object {
		internal ClientFluidTypeExtensions ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		[global::System.Obsolete (@"Use 'Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions.Dummy'. This class will be removed in a future release.")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']/method[@name='of' and count(parameter)=1 and parameter[1][@type='net.minecraftforge.fluids.FluidType']]"
		[global::System.Obsolete (@"Use 'Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions.Of'. This class will be removed in a future release.")]
		[Register ("of", "(Lnet/minecraftforge/fluids/FluidType;)Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;", "")]
		public static unsafe global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions? Of (global::Net.Minecraftforge.Fluids.FluidType? fluidType)
		{
			const string __id = "of.(Lnet/minecraftforge/fluids/FluidType;)Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fluidType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fluidType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fluidType);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", typeof (ClientFluidTypeExtensions));

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']"
	[Register ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", "", "Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensionsInvoker")]
	public partial interface IClientFluidTypeExtensions : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", typeof (IClientFluidTypeExtensions), isInterface: true);


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		private static Delegate? cb_getColorTint;
#pragma warning disable 0169
		private static Delegate GetGetColorTintHandler ()
		{
			if (cb_getColorTint == null)
				cb_getColorTint = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetColorTint));
			return cb_getColorTint;
		}

		private static int n_GetColorTint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ColorTint;
		}
#pragma warning restore 0169

		virtual unsafe int ColorTint {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']/method[@name='getColorTint' and count(parameter)=0]"
			[Register ("getColorTint", "()I", "GetGetColorTintHandler:Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions, AvventuraPokemon")]
			get {
				const string __id = "getColorTint.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientFluidTypeExtensions']/method[@name='of' and count(parameter)=1 and parameter[1][@type='net.minecraftforge.fluids.FluidType']]"
		[Register ("of", "(Lnet/minecraftforge/fluids/FluidType;)Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;", "")]
		public static unsafe global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions? Of (global::Net.Minecraftforge.Fluids.FluidType? fluidType)
		{
			const string __id = "of.(Lnet/minecraftforge/fluids/FluidType;)Lnet/minecraftforge/client/extensions/common/IClientFluidTypeExtensions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fluidType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fluidType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientFluidTypeExtensions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fluidType);
			}
		}

	}

	[global::Android.Runtime.Register ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", DoNotGenerateAcw=true)]
	internal partial class IClientFluidTypeExtensionsInvoker : global::Java.Lang.Object, IClientFluidTypeExtensions {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientFluidTypeExtensions", typeof (IClientFluidTypeExtensionsInvoker));

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

		public static IClientFluidTypeExtensions? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClientFluidTypeExtensions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.client.extensions.common.IClientFluidTypeExtensions'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClientFluidTypeExtensionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
