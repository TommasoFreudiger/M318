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

namespace Net.Optifine.Shaders {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']"
	[global::Android.Runtime.Register ("net/optifine/shaders/EntityAliases", DoNotGenerateAcw=true)]
	public partial class EntityAliases : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/shaders/EntityAliases", typeof (EntityAliases));

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

		protected EntityAliases (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']/constructor[@name='EntityAliases' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EntityAliases () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']/method[@name='getEntityAliasId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEntityAliasId", "(I)I", "")]
		public static unsafe int GetEntityAliasId (int entityId)
		{
			const string __id = "getEntityAliasId.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (entityId);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']/method[@name='resourcesReloaded' and count(parameter)=0]"
		[Register ("resourcesReloaded", "()V", "")]
		public static unsafe void ResourcesReloaded ()
		{
			const string __id = "resourcesReloaded.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.shaders']/class[@name='EntityAliases']/method[@name='update' and count(parameter)=1 and parameter[1][@type='net.optifine.shaders.IShaderPack']]"
		[Register ("update", "(Lnet/optifine/shaders/IShaderPack;)V", "")]
		public static unsafe void Update (global::Net.Optifine.Shaders.IShaderPack? shaderPack)
		{
			const string __id = "update.(Lnet/optifine/shaders/IShaderPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((shaderPack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shaderPack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (shaderPack);
			}
		}

	}
}
