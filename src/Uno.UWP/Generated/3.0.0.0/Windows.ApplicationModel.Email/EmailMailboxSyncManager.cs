#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxSyncManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Email.EmailMailboxSyncStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxSyncStatus EmailMailboxSyncManager.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxSyncStatus%20EmailMailboxSyncManager.Status");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxSyncManager", "EmailMailboxSyncStatus EmailMailboxSyncManager.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset LastSuccessfulSyncTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset EmailMailboxSyncManager.LastSuccessfulSyncTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20EmailMailboxSyncManager.LastSuccessfulSyncTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxSyncManager", "DateTimeOffset EmailMailboxSyncManager.LastSuccessfulSyncTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset LastAttemptedSyncTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset EmailMailboxSyncManager.LastAttemptedSyncTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20EmailMailboxSyncManager.LastAttemptedSyncTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxSyncManager", "DateTimeOffset EmailMailboxSyncManager.LastAttemptedSyncTime");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.Status.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.LastSuccessfulSyncTime.get
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.LastAttemptedSyncTime.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> SyncAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> EmailMailboxSyncManager.SyncAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20EmailMailboxSyncManager.SyncAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.SyncStatusChanged.add
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.SyncStatusChanged.remove
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.Status.set
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.LastSuccessfulSyncTime.set
		// Forced skipping of method Windows.ApplicationModel.Email.EmailMailboxSyncManager.LastAttemptedSyncTime.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Email.EmailMailboxSyncManager, object> SyncStatusChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxSyncManager", "event TypedEventHandler<EmailMailboxSyncManager, object> EmailMailboxSyncManager.SyncStatusChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxSyncManager", "event TypedEventHandler<EmailMailboxSyncManager, object> EmailMailboxSyncManager.SyncStatusChanged");
			}
		}
		#endif
	}
}
