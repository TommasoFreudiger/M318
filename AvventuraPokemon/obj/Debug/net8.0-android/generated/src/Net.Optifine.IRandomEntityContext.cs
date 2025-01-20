using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Optifine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']"
	[Register ("net/optifine/RandomEntityContext", "", "Net.Optifine.IRandomEntityContextInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IRandomEntityContext : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/RandomEntityContext", typeof (IRandomEntityContext), isInterface: true);

		string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Net.Optifine.IRandomEntityContextInvoker, AvventuraPokemon")]
			get; 
		}

		string? ResourceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getResourceName' and count(parameter)=0]"
			[Register ("getResourceName", "()Ljava/lang/String;", "GetGetResourceNameHandler:Net.Optifine.IRandomEntityContextInvoker, AvventuraPokemon")]
			get; 
		}

		private static Delegate? cb_getConnectedParser;
#pragma warning disable 0169
		private static Delegate GetGetConnectedParserHandler ()
		{
			if (cb_getConnectedParser == null)
				cb_getConnectedParser = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetConnectedParser));
			return cb_getConnectedParser;
		}

		private static IntPtr n_GetConnectedParser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ConnectedParser);
		}
#pragma warning restore 0169

		virtual unsafe global::Net.Optifine.Config.ConnectedParser? ConnectedParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getConnectedParser' and count(parameter)=0]"
			[Register ("getConnectedParser", "()Lnet/optifine/config/ConnectedParser;", "GetGetConnectedParserHandler:Net.Optifine.IRandomEntityContext, AvventuraPokemon")]
			get {
				const string __id = "getConnectedParser.()Lnet/optifine/config/ConnectedParser;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Net.Optifine.Config.ConnectedParser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		private static Delegate? cb_getResourceNameCapital;
#pragma warning disable 0169
		private static Delegate GetGetResourceNameCapitalHandler ()
		{
			if (cb_getResourceNameCapital == null)
				cb_getResourceNameCapital = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceNameCapital));
			return cb_getResourceNameCapital;
		}

		private static IntPtr n_GetResourceNameCapital (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ResourceNameCapital);
		}
#pragma warning restore 0169

		virtual unsafe string? ResourceNameCapital {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getResourceNameCapital' and count(parameter)=0]"
			[Register ("getResourceNameCapital", "()Ljava/lang/String;", "GetGetResourceNameCapitalHandler:Net.Optifine.IRandomEntityContext, AvventuraPokemon")]
			get {
				const string __id = "getResourceNameCapital.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		private static Delegate? cb_getResourceNamePlural;
#pragma warning disable 0169
		private static Delegate GetGetResourceNamePluralHandler ()
		{
			if (cb_getResourceNamePlural == null)
				cb_getResourceNamePlural = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceNamePlural));
			return cb_getResourceNamePlural;
		}

		private static IntPtr n_GetResourceNamePlural (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ResourceNamePlural);
		}
#pragma warning restore 0169

		virtual unsafe string? ResourceNamePlural {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getResourceNamePlural' and count(parameter)=0]"
			[Register ("getResourceNamePlural", "()Ljava/lang/String;", "GetGetResourceNamePluralHandler:Net.Optifine.IRandomEntityContext, AvventuraPokemon")]
			get {
				const string __id = "getResourceNamePlural.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/interface[@name='RandomEntityContext']/method[@name='getResourceKeys' and count(parameter)=0]"
		[Register ("getResourceKeys", "()[Ljava/lang/String;", "GetGetResourceKeysHandler:Net.Optifine.IRandomEntityContextInvoker, AvventuraPokemon")]
		string[]? GetResourceKeys ();

		// Metadata.xml XPath class reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']"
		[global::Android.Runtime.Register ("net/optifine/RandomEntityContext$Models", DoNotGenerateAcw=true)]
		public partial class Models : global::Java.Lang.Object, global::Net.Optifine.IRandomEntityContext {
			static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/RandomEntityContext$Models", typeof (Models));

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

			protected Models (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']/constructor[@name='RandomEntityContext.Models' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Models () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext.Models> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			public virtual unsafe string? Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getRendererCache;
#pragma warning disable 0169
			static Delegate GetGetRendererCacheHandler ()
			{
				if (cb_getRendererCache == null)
					cb_getRendererCache = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRendererCache));
				return cb_getRendererCache;
			}

			static IntPtr n_GetRendererCache (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext.Models> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.RendererCache);
			}
#pragma warning restore 0169

			public virtual unsafe global::Net.Optifine.Entity.Model.RendererCache? RendererCache {
				// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']/method[@name='getRendererCache' and count(parameter)=0]"
				[Register ("getRendererCache", "()Lnet/optifine/entity/model/RendererCache;", "GetGetRendererCacheHandler")]
				get {
					const string __id = "getRendererCache.()Lnet/optifine/entity/model/RendererCache;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Net.Optifine.Entity.Model.RendererCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getResourceName;
#pragma warning disable 0169
			static Delegate GetGetResourceNameHandler ()
			{
				if (cb_getResourceName == null)
					cb_getResourceName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceName));
				return cb_getResourceName;
			}

			static IntPtr n_GetResourceName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext.Models> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.ResourceName);
			}
#pragma warning restore 0169

			public virtual unsafe string? ResourceName {
				// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']/method[@name='getResourceName' and count(parameter)=0]"
				[Register ("getResourceName", "()Ljava/lang/String;", "GetGetResourceNameHandler")]
				get {
					const string __id = "getResourceName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getResourceKeys;
#pragma warning disable 0169
			static Delegate GetGetResourceKeysHandler ()
			{
				if (cb_getResourceKeys == null)
					cb_getResourceKeys = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceKeys));
				return cb_getResourceKeys;
			}

			static IntPtr n_GetResourceKeys (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext.Models> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetResourceKeys ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='net.optifine']/class[@name='RandomEntityContext.Models']/method[@name='getResourceKeys' and count(parameter)=0]"
			[Register ("getResourceKeys", "()[Ljava/lang/String;", "GetGetResourceKeysHandler")]
			public virtual unsafe string[]? GetResourceKeys ()
			{
				const string __id = "getResourceKeys.()[Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("net/optifine/RandomEntityContext", DoNotGenerateAcw=true)]
	internal partial class IRandomEntityContextInvoker : global::Java.Lang.Object, IRandomEntityContext {
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/optifine/RandomEntityContext", typeof (IRandomEntityContextInvoker));

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

		public static IRandomEntityContext? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRandomEntityContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'net.optifine.RandomEntityContext'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRandomEntityContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string? Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getResourceName;
#pragma warning disable 0169
		static Delegate GetGetResourceNameHandler ()
		{
			if (cb_getResourceName == null)
				cb_getResourceName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceName));
			return cb_getResourceName;
		}

		static IntPtr n_GetResourceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ResourceName);
		}
#pragma warning restore 0169

		IntPtr id_getResourceName;
		public unsafe string? ResourceName {
			get {
				if (id_getResourceName == IntPtr.Zero)
					id_getResourceName = JNIEnv.GetMethodID (class_ref, "getResourceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getResourceKeys;
#pragma warning disable 0169
		static Delegate GetGetResourceKeysHandler ()
		{
			if (cb_getResourceKeys == null)
				cb_getResourceKeys = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetResourceKeys));
			return cb_getResourceKeys;
		}

		static IntPtr n_GetResourceKeys (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Net.Optifine.IRandomEntityContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetResourceKeys ());
		}
#pragma warning restore 0169

		IntPtr id_getResourceKeys;
		public unsafe string[]? GetResourceKeys ()
		{
			if (id_getResourceKeys == IntPtr.Zero)
				id_getResourceKeys = JNIEnv.GetMethodID (class_ref, "getResourceKeys", "()[Ljava/lang/String;");
			return (string[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceKeys), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}
}
