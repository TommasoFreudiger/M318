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

namespace Optifine.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']"
	[global::Android.Runtime.Register ("optifine/json/ItemList", DoNotGenerateAcw=true)]
	public partial class ItemList : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("optifine/json/ItemList", typeof (ItemList));

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

		protected ItemList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/constructor[@name='ItemList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ItemList () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/constructor[@name='ItemList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ItemList (string? s) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/constructor[@name='ItemList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ItemList (string? s, string? sp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/constructor[@name='ItemList' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe ItemList (string? s, string? sp, bool isMultiToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				__args [2] = new JniArgumentValue (isMultiToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

		static Delegate? cb_getItems;
#pragma warning disable 0169
		static Delegate GetGetItemsHandler ()
		{
			if (cb_getItems == null)
				cb_getItems = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetItems));
			return cb_getItems;
		}

		static IntPtr n_GetItems (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Items);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IList? Items {
			// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='getItems' and count(parameter)=0]"
			[Register ("getItems", "()Ljava/util/List;", "GetGetItemsHandler")]
			get {
				const string __id = "getItems.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_add_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_ILjava_lang_String_Handler ()
		{
			if (cb_add_ILjava_lang_String_ == null)
				cb_add_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_Add_ILjava_lang_String_));
			return cb_add_ILjava_lang_String_;
		}

		static void n_Add_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int i, IntPtr native_item)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var item = JNIEnv.GetString (native_item, JniHandleOwnership.DoNotTransfer);
			__this.Add (i, item);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("add", "(ILjava/lang/String;)V", "GetAdd_ILjava_lang_String_Handler")]
		public virtual unsafe void Add (int i, string? item)
		{
			const string __id = "add.(ILjava/lang/String;)V";
			IntPtr native_item = JNIEnv.NewString ((string?)item);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
				__args [1] = new JniArgumentValue (native_item);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static Delegate? cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Add_Ljava_lang_String_));
			return cb_add_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var item = JNIEnv.GetString (native_item, JniHandleOwnership.DoNotTransfer);
			__this.Add (item);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler")]
		public virtual unsafe void Add (string? item)
		{
			const string __id = "add.(Ljava/lang/String;)V";
			IntPtr native_item = JNIEnv.NewString ((string?)item);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_item);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
			}
		}

		static Delegate? cb_addAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_String_Handler ()
		{
			if (cb_addAll_Ljava_lang_String_ == null)
				cb_addAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AddAll_Ljava_lang_String_));
			return cb_addAll_Ljava_lang_String_;
		}

		static void n_AddAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addAll", "(Ljava/lang/String;)V", "GetAddAll_Ljava_lang_String_Handler")]
		public virtual unsafe void AddAll (string? s)
		{
			const string __id = "addAll.(Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate? cb_addAll_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAll_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAll_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddAll_Ljava_lang_String_Ljava_lang_String_));
			return cb_addAll_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddAll_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_sp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (s, sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAll", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddAll_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddAll (string? s, string? sp)
		{
			const string __id = "addAll.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

		static Delegate? cb_addAll_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_addAll_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_addAll_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZ_V (n_AddAll_Ljava_lang_String_Ljava_lang_String_Z));
			return cb_addAll_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_AddAll_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_sp, bool isMultiToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (s, sp, isMultiToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='addAll' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("addAll", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetAddAll_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void AddAll (string? s, string? sp, bool isMultiToken)
		{
			const string __id = "addAll.(Ljava/lang/String;Ljava/lang/String;Z)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				__args [2] = new JniArgumentValue (isMultiToken);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

		static Delegate? cb_addAll_Loptifine_json_ItemList_;
#pragma warning disable 0169
		static Delegate GetAddAll_Loptifine_json_ItemList_Handler ()
		{
			if (cb_addAll_Loptifine_json_ItemList_ == null)
				cb_addAll_Loptifine_json_ItemList_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AddAll_Loptifine_json_ItemList_));
			return cb_addAll_Loptifine_json_ItemList_;
		}

		static void n_AddAll_Loptifine_json_ItemList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var list = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (native_list, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (list);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='optifine.json.ItemList']]"
		[Register ("addAll", "(Loptifine/json/ItemList;)V", "GetAddAll_Loptifine_json_ItemList_Handler")]
		public virtual unsafe void AddAll (global::Optifine.Json.ItemList? list)
		{
			const string __id = "addAll.(Loptifine/json/ItemList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((list == null) ? IntPtr.Zero : ((global::Java.Lang.Object) list).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (list);
			}
		}

		static Delegate? cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Clear));
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_Get_I));
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Get (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/String;", "GetGet_IHandler")]
		public virtual unsafe string? Get (int i)
		{
			const string __id = "get.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_getArray;
#pragma warning disable 0169
		static Delegate GetGetArrayHandler ()
		{
			if (cb_getArray == null)
				cb_getArray = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetArray));
			return cb_getArray;
		}

		static IntPtr n_GetArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='getArray' and count(parameter)=0]"
		[Register ("getArray", "()[Ljava/lang/String;", "GetGetArrayHandler")]
		public virtual unsafe string[]? GetArray ()
		{
			const string __id = "getArray.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate? cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Reset));
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_setSP_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSP_Ljava_lang_String_Handler ()
		{
			if (cb_setSP_Ljava_lang_String_ == null)
				cb_setSP_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetSP_Ljava_lang_String_));
			return cb_setSP_Ljava_lang_String_;
		}

		static void n_SetSP_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.SetSP (sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='setSP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSP", "(Ljava/lang/String;)V", "GetSetSP_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSP (string? sp)
		{
			const string __id = "setSP.(Ljava/lang/String;)V";
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

		static Delegate? cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Size));
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSplit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_Split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_));
			return cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_Split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_sp, IntPtr native_append)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			var append = global::Android.Runtime.JavaList.FromJniHandle (native_append, JniHandleOwnership.DoNotTransfer);
			__this.Split (s, sp, append);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='split' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List']]"
		[Register ("split", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "GetSplit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void Split (string? s, string? sp, global::System.Collections.IList? append)
		{
			const string __id = "split.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			IntPtr native_append = global::Android.Runtime.JavaList.ToLocalJniHandle (append);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				__args [2] = new JniArgumentValue (native_append);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
				JNIEnv.DeleteLocalRef (native_append);
				global::System.GC.KeepAlive (append);
			}
		}

		static Delegate? cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetSplit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ZHandler ()
		{
			if (cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z == null)
				cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLZ_V (n_Split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z));
			return cb_split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z;
		}

		static void n_Split_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_sp, IntPtr native_append, bool isMultiToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			var append = global::Android.Runtime.JavaList.FromJniHandle (native_append, JniHandleOwnership.DoNotTransfer);
			__this.Split (s, sp, append, isMultiToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='split' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List'] and parameter[4][@type='boolean']]"
		[Register ("split", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Z)V", "GetSplit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ZHandler")]
		public virtual unsafe void Split (string? s, string? sp, global::System.Collections.IList? append, bool isMultiToken)
		{
			const string __id = "split.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Z)V";
			IntPtr native_s = JNIEnv.NewString ((string?)s);
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			IntPtr native_append = global::Android.Runtime.JavaList.ToLocalJniHandle (append);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_sp);
				__args [2] = new JniArgumentValue (native_append);
				__args [3] = new JniArgumentValue (isMultiToken);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_sp);
				JNIEnv.DeleteLocalRef (native_append);
				global::System.GC.KeepAlive (append);
			}
		}

		static Delegate? cb_toString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToString_Ljava_lang_String_Handler ()
		{
			if (cb_toString_Ljava_lang_String_ == null)
				cb_toString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_ToString_Ljava_lang_String_));
			return cb_toString_Ljava_lang_String_;
		}

		static IntPtr n_ToString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Optifine.Json.ItemList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var sp = JNIEnv.GetString (native_sp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToString (sp));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='optifine.json']/class[@name='ItemList']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToString_Ljava_lang_String_Handler")]
		public virtual unsafe string? ToString (string? sp)
		{
			const string __id = "toString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_sp = JNIEnv.NewString ((string?)sp);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sp);
			}
		}

	}
}
