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

namespace Net.Optifine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']"
	[global::Android.Runtime.Register ("net/optifine/util/TextureUtils", DoNotGenerateAcw=true)]
	public partial class TextureUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/field[@name='SPRITE_PREFIX_BLOCKS']"
		[Register ("SPRITE_PREFIX_BLOCKS")]
		public const string SpritePrefixBlocks = (string) "minecraft:block/";

		// Metadata.xml XPath field reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/field[@name='SPRITE_PREFIX_ITEMS']"
		[Register ("SPRITE_PREFIX_ITEMS")]
		public const string SpritePrefixItems = (string) "minecraft:item/";

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/util/TextureUtils", typeof (TextureUtils));

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

		protected TextureUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/constructor[@name='TextureUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextureUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe int GLMaximumTextureSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='getGLMaximumTextureSize' and count(parameter)=0]"
			[Register ("getGLMaximumTextureSize", "()I", "")]
			get {
				const string __id = "getGLMaximumTextureSize.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='applyAnisotropicLevel' and count(parameter)=0]"
		[Register ("applyAnisotropicLevel", "()V", "")]
		public static unsafe void ApplyAnisotropicLevel ()
		{
			const string __id = "applyAnisotropicLevel.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='bindTexture' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bindTexture", "(I)V", "")]
		public static unsafe void BindTexture (int glTexId)
		{
			const string __id = "bindTexture.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (glTexId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='ceilPowerOfTwo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ceilPowerOfTwo", "(I)I", "")]
		public static unsafe int CeilPowerOfTwo (int val)
		{
			const string __id = "ceilPowerOfTwo.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='debugTextureDeleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("debugTextureDeleted", "(I)V", "")]
		public static unsafe void DebugTextureDeleted (int id)
		{
			const string __id = "debugTextureDeleted.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='debugTextureGenerated' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("debugTextureGenerated", "(I)V", "")]
		public static unsafe void DebugTextureGenerated (int id)
		{
			const string __id = "debugTextureGenerated.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='fixResourcePath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("fixResourcePath", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? FixResourcePath (string? path, string? basePath)
		{
			const string __id = "fixResourcePath.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			IntPtr native_basePath = JNIEnv.NewString ((string?)basePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_basePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_basePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='getBasePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBasePath", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetBasePath (string? path)
		{
			const string __id = "getBasePath.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='getPowerOfTwo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPowerOfTwo", "(I)I", "")]
		public static unsafe int GetPowerOfTwo (int val)
		{
			const string __id = "getPowerOfTwo.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='getStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getStackTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTrace (global::Java.Lang.Throwable? t)
		{
			const string __id = "getStackTrace.(Ljava/lang/Throwable;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='isPowerOfTwo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPowerOfTwo", "(I)Z", "")]
		public static unsafe bool IsPowerOfTwo (int x)
		{
			const string __id = "isPowerOfTwo.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='registerResourceListener' and count(parameter)=0]"
		[Register ("registerResourceListener", "()V", "")]
		public static unsafe void RegisterResourceListener ()
		{
			const string __id = "registerResourceListener.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='registerTickableTextures' and count(parameter)=0]"
		[Register ("registerTickableTextures", "()V", "")]
		public static unsafe void RegisterTickableTextures ()
		{
			const string __id = "registerTickableTextures.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='resetDataUnpacking' and count(parameter)=0]"
		[Register ("resetDataUnpacking", "()V", "")]
		public static unsafe void ResetDataUnpacking ()
		{
			const string __id = "resetDataUnpacking.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='saveGlTexture' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("saveGlTexture", "(Ljava/lang/String;IIII)V", "")]
		public static unsafe void SaveGlTexture (string? name, int textureId, int mipmapLevels, int width, int height)
		{
			const string __id = "saveGlTexture.(Ljava/lang/String;IIII)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (textureId);
				__args [2] = new JniArgumentValue (mipmapLevels);
				__args [3] = new JniArgumentValue (width);
				__args [4] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='scaleToGrid' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scaleToGrid", "(II)I", "")]
		public static unsafe int ScaleToGrid (int size, int sizeGrid)
		{
			const string __id = "scaleToGrid.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue (sizeGrid);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='scaleToMin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scaleToMin", "(II)I", "")]
		public static unsafe int ScaleToMin (int size, int sizeMin)
		{
			const string __id = "scaleToMin.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue (sizeMin);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='toAbgr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toAbgr", "(I)I", "")]
		public static unsafe int ToAbgr (int argb)
		{
			const string __id = "toAbgr.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (argb);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='twoToPower' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("twoToPower", "(I)I", "")]
		public static unsafe int TwoToPower (int power)
		{
			const string __id = "twoToPower.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (power);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine.util']/class[@name='TextureUtils']/method[@name='update' and count(parameter)=0]"
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
