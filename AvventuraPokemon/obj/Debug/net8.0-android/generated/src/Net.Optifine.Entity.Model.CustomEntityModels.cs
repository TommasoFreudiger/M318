//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine.Entity.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']"
	[global::Android.Runtime.Register ("net/optifine/entity/model/CustomEntityModels", DoNotGenerateAcw=true)]
	public partial class CustomEntityModels : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/field[@name='PREFIX_OPTIFINE_CEM']"
		[Register ("PREFIX_OPTIFINE_CEM")]
		public const string PrefixOptifineCem = (string) "optifine/cem/";

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/field[@name='SUFFIX_JEM']"
		[Register ("SUFFIX_JEM")]
		public const string SuffixJem = (string) ".jem";

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/field[@name='SUFFIX_PROPERTIES']"
		[Register ("SUFFIX_PROPERTIES")]
		public const string SuffixProperties = (string) ".properties";

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/entity/model/CustomEntityModels", typeof (CustomEntityModels));

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

		protected CustomEntityModels (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/constructor[@name='CustomEntityModels' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEntityModels () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "")]
			get {
				const string __id = "isActive.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int MatchingRuleIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/method[@name='getMatchingRuleIndex' and count(parameter)=0]"
			[Register ("getMatchingRuleIndex", "()I", "")]
			get {
				const string __id = "getMatchingRuleIndex.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.entity.model']/class[@name='CustomEntityModels']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "")]
		public static unsafe void Update ()
		{
			const string __id = "update.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
