using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Minecraftforge.Event.Entity.Living {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.minecraftforge.event.entity.living']/interface[@name='ILivingTargetType']"
	[Register ("net/minecraftforge/event/entity/living/ILivingTargetType", "", "Net.Minecraftforge.Event.Entity.Living.ILivingTargetTypeInvoker")]
	public partial interface ILivingTargetType : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("net/minecraftforge/event/entity/living/ILivingTargetType", DoNotGenerateAcw=true)]
	internal partial class ILivingTargetTypeInvoker : global::Java.Lang.Object, ILivingTargetType {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/minecraftforge/event/entity/living/ILivingTargetType", typeof (ILivingTargetTypeInvoker));

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

		public static ILivingTargetType? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILivingTargetType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.minecraftforge.event.entity.living.ILivingTargetType'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILivingTargetTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
