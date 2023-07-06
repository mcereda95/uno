#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlSettings 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsScriptNotifyAllowed
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebViewControlSettings.IsScriptNotifyAllowed is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20WebViewControlSettings.IsScriptNotifyAllowed");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.UI.WebViewControlSettings", "bool WebViewControlSettings.IsScriptNotifyAllowed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsJavaScriptEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebViewControlSettings.IsJavaScriptEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20WebViewControlSettings.IsJavaScriptEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.UI.WebViewControlSettings", "bool WebViewControlSettings.IsJavaScriptEnabled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsIndexedDBEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool WebViewControlSettings.IsIndexedDBEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20WebViewControlSettings.IsIndexedDBEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.UI.WebViewControlSettings", "bool WebViewControlSettings.IsIndexedDBEnabled");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsJavaScriptEnabled.set
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsJavaScriptEnabled.get
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsIndexedDBEnabled.set
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsIndexedDBEnabled.get
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsScriptNotifyAllowed.set
		// Forced skipping of method Windows.Web.UI.WebViewControlSettings.IsScriptNotifyAllowed.get
	}
}
