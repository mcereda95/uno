#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2HttpHeadersCollectionIterator : global::Windows.Foundation.Collections.IIterator<global::System.Collections.Generic.KeyValuePair<string, string>>
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.KeyValuePair<string, string> Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member KeyValuePair<string, string> CoreWebView2HttpHeadersCollectionIterator.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=KeyValuePair%3Cstring%2C%20string%3E%20CoreWebView2HttpHeadersCollectionIterator.Current");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool HasCurrent
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2HttpHeadersCollectionIterator.HasCurrent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreWebView2HttpHeadersCollectionIterator.HasCurrent");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator.Current.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator.HasCurrent.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool MoveNext()
		{
			throw new global::System.NotImplementedException("The member bool CoreWebView2HttpHeadersCollectionIterator.MoveNext() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CoreWebView2HttpHeadersCollectionIterator.MoveNext%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint GetMany( global::System.Collections.Generic.KeyValuePair<string, string>[] items)
		{
			throw new global::System.NotImplementedException("The member uint CoreWebView2HttpHeadersCollectionIterator.GetMany(KeyValuePair<string, string>[] items) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20CoreWebView2HttpHeadersCollectionIterator.GetMany%28KeyValuePair%3Cstring%2C%20string%3E%5B%5D%20items%29");
		}
		#endif
		// Processing: Windows.Foundation.Collections.IIterator<System.Collections.Generic.KeyValuePair<string, string>>
	}
}
