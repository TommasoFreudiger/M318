using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Common.Extensions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.common.extensions']/interface[@name='IForgeBlockEntity']"
	[Register ("net/minecraftforge/common/extensions/IForgeBlockEntity", "", "Net.Minecraftforge.Common.Extensions.IForgeBlockEntityInvoker")]
	public partial interface IForgeBlockEntity : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/common/extensions/IForgeBlockEntity", typeof (IForgeBlockEntity), isInterface: true);

		private static Delegate? cb_onChunkUnloaded;
#pragma warning disable 0169
		private static Delegate GetOnChunkUnloadedHandler ()
		{
			if (cb_onChunkUnloaded == null)
				cb_onChunkUnloaded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnChunkUnloaded));
			return cb_onChunkUnloaded;
		}

		private static void n_OnChunkUnloaded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Extensions.IForgeBlockEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnChunkUnloaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.extensions']/interface[@name='IForgeBlockEntity']/method[@name='onChunkUnloaded' and count(parameter)=0]"
		[Register ("onChunkUnloaded", "()V", "GetOnChunkUnloadedHandler:Net.Minecraftforge.Common.Extensions.IForgeBlockEntity, AvventuraPokemon")]
		virtual unsafe void OnChunkUnloaded ()
		{
			const string __id = "onChunkUnloaded.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		private static Delegate? cb_requestModelDataUpdate;
#pragma warning disable 0169
		private static Delegate GetRequestModelDataUpdateHandler ()
		{
			if (cb_requestModelDataUpdate == null)
				cb_requestModelDataUpdate = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_RequestModelDataUpdate));
			return cb_requestModelDataUpdate;
		}

		private static void n_RequestModelDataUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Minecraftforge.Common.Extensions.IForgeBlockEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.RequestModelDataUpdate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.minecraftforge.common.extensions']/interface[@name='IForgeBlockEntity']/method[@name='requestModelDataUpdate' and count(parameter)=0]"
		[Register ("requestModelDataUpdate", "()V", "GetRequestModelDataUpdateHandler:Net.Minecraftforge.Common.Extensions.IForgeBlockEntity, AvventuraPokemon")]
		virtual unsafe void RequestModelDataUpdate ()
		{
			const string __id = "requestModelDataUpdate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("net/minecraftforge/common/extensions/IForgeBlockEntity", DoNotGenerateAcw=true)]
	internal partial class IForgeBlockEntityInvoker : global::Java.Lang.Object, IForgeBlockEntity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/common/extensions/IForgeBlockEntity", typeof (IForgeBlockEntityInvoker));

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

		public static IForgeBlockEntity? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IForgeBlockEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.common.extensions.IForgeBlockEntity'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IForgeBlockEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
