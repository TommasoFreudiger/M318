using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Common.Extensions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.common.extensions']/interface[@name='IForgeEntity']"
	[Register ("net/minecraftforge/common/extensions/IForgeEntity", "", "Net.Minecraftforge.Common.Extensions.IForgeEntityInvoker")]
	public partial interface IForgeEntity : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/common/extensions/IForgeEntity", typeof (IForgeEntity), isInterface: true);

		private static Delegate? cb_isAddedToWorld;
#pragma warning disable 0169
		private static Delegate GetIsAddedToWorldHandler ()
		{
			if (cb_isAddedToWorld == null)
				cb_isAddedToWorld = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsAddedToWorld));
			return cb_isAddedToWorld;
		}

		private static bool n_IsAddedToWorld (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Extensions.IForgeEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsAddedToWorld;
		}
#pragma warning restore 0169

		virtual unsafe bool IsAddedToWorld {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.extensions']/interface[@name='IForgeEntity']/method[@name='isAddedToWorld' and count(parameter)=0]"
			[Register ("isAddedToWorld", "()Z", "GetIsAddedToWorldHandler:Net.Minecraftforge.Common.Extensions.IForgeEntity, AvventuraPokemon")]
			get {
				const string __id = "isAddedToWorld.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("net/minecraftforge/common/extensions/IForgeEntity", DoNotGenerateAcw=true)]
	internal partial class IForgeEntityInvoker : global::Java.Lang.Object, IForgeEntity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/common/extensions/IForgeEntity", typeof (IForgeEntityInvoker));

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

		public static IForgeEntity? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IForgeEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.common.extensions.IForgeEntity'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IForgeEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
