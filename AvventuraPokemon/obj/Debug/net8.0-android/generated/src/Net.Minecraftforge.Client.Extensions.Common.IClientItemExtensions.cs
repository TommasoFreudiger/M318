using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Client.Extensions.Common {

	[Register ("net/minecraftforge/client/extensions/common/IClientItemExtensions", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions' type. This class will be removed in a future release.")]
	public abstract class ClientItemExtensions : Java.Lang.Object {
		internal ClientItemExtensions ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientItemExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		[global::System.Obsolete (@"Use 'Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.Dummy'. This class will be removed in a future release.")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientItemExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientItemExtensions", typeof (ClientItemExtensions));

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientItemExtensions']"
	[Register ("net/minecraftforge/client/extensions/common/IClientItemExtensions", "", "Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensionsInvoker")]
	public partial interface IClientItemExtensions : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientItemExtensions", typeof (IClientItemExtensions), isInterface: true);


		// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/interface[@name='IClientItemExtensions']/field[@name='DUMMY']"
		[Register ("DUMMY")]
		public static global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions? Dummy {
			get {
				const string __id = "DUMMY.Lnet/minecraftforge/client/extensions/common/IClientItemExtensions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']"
		[global::Android.Runtime.Register ("net/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext", DoNotGenerateAcw=true)]
		public sealed partial class FontContext : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']/field[@name='ITEM_COUNT']"
			[Register ("ITEM_COUNT")]
			public static global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext? ItemCount {
				get {
					const string __id = "ITEM_COUNT.Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']/field[@name='SELECTED_ITEM_NAME']"
			[Register ("SELECTED_ITEM_NAME")]
			public static global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext? SelectedItemName {
				get {
					const string __id = "SELECTED_ITEM_NAME.Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']/field[@name='TOOLTIP']"
			[Register ("TOOLTIP")]
			public static global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext? Tooltip {
				get {
					const string __id = "TOOLTIP.Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext", typeof (FontContext));

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

			internal FontContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;", "")]
			public static unsafe global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.client.extensions.common']/class[@name='IClientItemExtensions.FontContext']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;", "")]
			public static unsafe global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext[]? Values ()
			{
				const string __id = "values.()[Lnet/minecraftforge/client/extensions/common/IClientItemExtensions$FontContext;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Net.Minecraftforge.Client.Extensions.Common.IClientItemExtensions.FontContext));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("net/minecraftforge/client/extensions/common/IClientItemExtensions", DoNotGenerateAcw=true)]
	internal partial class IClientItemExtensionsInvoker : global::Java.Lang.Object, IClientItemExtensions {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/client/extensions/common/IClientItemExtensions", typeof (IClientItemExtensionsInvoker));

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

		public static IClientItemExtensions? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClientItemExtensions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.client.extensions.common.IClientItemExtensions'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClientItemExtensionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
