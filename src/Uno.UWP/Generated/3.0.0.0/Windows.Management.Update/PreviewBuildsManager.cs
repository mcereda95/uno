#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Management.Update
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PreviewBuildsManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ArePreviewBuildsAllowed
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PreviewBuildsManager.ArePreviewBuildsAllowed is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PreviewBuildsManager.ArePreviewBuildsAllowed");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Management.Update.PreviewBuildsManager", "bool PreviewBuildsManager.ArePreviewBuildsAllowed");
			}
		}
		#endif
		// Forced skipping of method Windows.Management.Update.PreviewBuildsManager.ArePreviewBuildsAllowed.get
		// Forced skipping of method Windows.Management.Update.PreviewBuildsManager.ArePreviewBuildsAllowed.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Management.Update.PreviewBuildsState GetCurrentState()
		{
			throw new global::System.NotImplementedException("The member PreviewBuildsState PreviewBuildsManager.GetCurrentState() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PreviewBuildsState%20PreviewBuildsManager.GetCurrentState%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> SyncAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> PreviewBuildsManager.SyncAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20PreviewBuildsManager.SyncAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Management.Update.PreviewBuildsManager GetDefault()
		{
			throw new global::System.NotImplementedException("The member PreviewBuildsManager PreviewBuildsManager.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PreviewBuildsManager%20PreviewBuildsManager.GetDefault%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsSupported()
		{
			throw new global::System.NotImplementedException("The member bool PreviewBuildsManager.IsSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PreviewBuildsManager.IsSupported%28%29");
		}
		#endif
	}
}
