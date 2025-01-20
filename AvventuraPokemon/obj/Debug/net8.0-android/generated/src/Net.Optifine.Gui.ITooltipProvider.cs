using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Gui {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine.gui']/interface[@name='TooltipProvider']"
	[Register ("net/optifine/gui/TooltipProvider", "", "Net.Optifine.Gui.ITooltipProviderInvoker")]
	public partial interface ITooltipProvider : IJavaObject, IJavaPeerable {
		bool IsRenderBorder {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.gui']/interface[@name='TooltipProvider']/method[@name='isRenderBorder' and count(parameter)=0]"
			[Register ("isRenderBorder", "()Z", "GetIsRenderBorderHandler:Net.Optifine.Gui.ITooltipProviderInvoker, AvventuraPokemon")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("net/optifine/gui/TooltipProvider", DoNotGenerateAcw=true)]
	internal partial class ITooltipProviderInvoker : global::Java.Lang.Object, ITooltipProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/gui/TooltipProvider", typeof (ITooltipProviderInvoker));

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

		public static ITooltipProvider? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITooltipProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.gui.TooltipProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITooltipProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_isRenderBorder;
#pragma warning disable 0169
		static Delegate GetIsRenderBorderHandler ()
		{
			if (cb_isRenderBorder == null)
				cb_isRenderBorder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsRenderBorder));
			return cb_isRenderBorder;
		}

		static bool n_IsRenderBorder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.Gui.ITooltipProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsRenderBorder;
		}
#pragma warning restore 0169

		IntPtr id_isRenderBorder;
		public unsafe bool IsRenderBorder {
			get {
				if (id_isRenderBorder == IntPtr.Zero)
					id_isRenderBorder = JNIEnv.GetMethodID (class_ref, "isRenderBorder", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRenderBorder);
			}
		}

	}
}
