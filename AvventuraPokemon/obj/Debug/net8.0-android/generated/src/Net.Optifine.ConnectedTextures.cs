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

namespace Net.Optifine {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']"
	[global::Android.Runtime.Register ("net/optifine/ConnectedTextures", DoNotGenerateAcw=true)]
	public partial class ConnectedTextures : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		protected const int Unknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='X_NEG_WEST']"
		[Register ("X_NEG_WEST")]
		protected const int XNegWest = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='X_POS_EAST']"
		[Register ("X_POS_EAST")]
		protected const int XPosEast = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='Y_NEG_DOWN']"
		[Register ("Y_NEG_DOWN")]
		protected const int YNegDown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='Y_POS_UP']"
		[Register ("Y_POS_UP")]
		protected const int YPosUp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='Z_NEG_NORTH']"
		[Register ("Z_NEG_NORTH")]
		protected const int ZNegNorth = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/field[@name='Z_POS_SOUTH']"
		[Register ("Z_POS_SOUTH")]
		protected const int ZPosSouth = (int) 3;

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/ConnectedTextures", typeof (ConnectedTextures));

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

		protected ConnectedTextures (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/constructor[@name='ConnectedTextures' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectedTextures () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='ConnectedTextures']/method[@name='getSpriteQuadCompactMaps' and count(parameter)=0]"
		[Register ("getSpriteQuadCompactMaps", "()[[Ljava/util/Map;", "")]
		protected static unsafe global::System.Collections.IDictionary[][]? GetSpriteQuadCompactMaps ()
		{
			const string __id = "getSpriteQuadCompactMaps.()[[Ljava/util/Map;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::System.Collections.IDictionary[][]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::System.Collections.IDictionary[]));
			} finally {
			}
		}

	}
}
