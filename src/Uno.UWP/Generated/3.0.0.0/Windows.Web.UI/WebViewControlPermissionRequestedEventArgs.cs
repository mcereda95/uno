#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlPermissionRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Web.UI.WebViewControlPermissionRequest PermissionRequest
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewControlPermissionRequest WebViewControlPermissionRequestedEventArgs.PermissionRequest is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WebViewControlPermissionRequest%20WebViewControlPermissionRequestedEventArgs.PermissionRequest");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlPermissionRequestedEventArgs.PermissionRequest.get
	}
}
