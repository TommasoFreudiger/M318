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

namespace Net.Optifine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']"
	[global::Android.Runtime.Register ("net/optifine/model/AttachmentType", DoNotGenerateAcw=true)]
	public sealed partial class AttachmentType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/field[@name='HANDHELD_ITEM']"
		[Register ("HANDHELD_ITEM")]
		public static global::Net.Optifine.Model.AttachmentType? HandheldItem {
			get {
				const string __id = "HANDHELD_ITEM.Lnet/optifine/model/AttachmentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/field[@name='HEAD']"
		[Register ("HEAD")]
		public static global::Net.Optifine.Model.AttachmentType? Head {
			get {
				const string __id = "HEAD.Lnet/optifine/model/AttachmentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/field[@name='LEAD']"
		[Register ("LEAD")]
		public static global::Net.Optifine.Model.AttachmentType? Lead {
			get {
				const string __id = "LEAD.Lnet/optifine/model/AttachmentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/field[@name='LEFT_HANDHELD_ITEM']"
		[Register ("LEFT_HANDHELD_ITEM")]
		public static global::Net.Optifine.Model.AttachmentType? LeftHandheldItem {
			get {
				const string __id = "LEFT_HANDHELD_ITEM.Lnet/optifine/model/AttachmentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/field[@name='RIGHT_HANDHELD_ITEM']"
		[Register ("RIGHT_HANDHELD_ITEM")]
		public static global::Net.Optifine.Model.AttachmentType? RightHandheldItem {
			get {
				const string __id = "RIGHT_HANDHELD_ITEM.Lnet/optifine/model/AttachmentType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/model/AttachmentType", typeof (AttachmentType));

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

		internal AttachmentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lnet/optifine/model/AttachmentType;", "")]
		public static unsafe global::Net.Optifine.Model.AttachmentType? Parse (string? str)
		{
			const string __id = "parse.(Ljava/lang/String;)Lnet/optifine/model/AttachmentType;";
			IntPtr native_str = JNIEnv.NewString ((string?)str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lnet/optifine/model/AttachmentType;", "")]
		public static unsafe global::Net.Optifine.Model.AttachmentType? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lnet/optifine/model/AttachmentType;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Net.Optifine.Model.AttachmentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.model']/class[@name='AttachmentType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lnet/optifine/model/AttachmentType;", "")]
		public static unsafe global::Net.Optifine.Model.AttachmentType[]? Values ()
		{
			const string __id = "values.()[Lnet/optifine/model/AttachmentType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Net.Optifine.Model.AttachmentType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Net.Optifine.Model.AttachmentType));
			} finally {
			}
		}

	}
}
