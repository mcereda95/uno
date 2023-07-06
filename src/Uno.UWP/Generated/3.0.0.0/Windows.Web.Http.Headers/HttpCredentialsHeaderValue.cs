#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HttpCredentialsHeaderValue : global::Windows.Foundation.IStringable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Web.Http.Headers.HttpNameValueHeaderValue> Parameters
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HttpNameValueHeaderValue> HttpCredentialsHeaderValue.Parameters is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CHttpNameValueHeaderValue%3E%20HttpCredentialsHeaderValue.Parameters");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Scheme
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpCredentialsHeaderValue.Scheme is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCredentialsHeaderValue.Scheme");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Token
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpCredentialsHeaderValue.Token is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCredentialsHeaderValue.Token");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpCredentialsHeaderValue( string scheme) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpCredentialsHeaderValue", "HttpCredentialsHeaderValue.HttpCredentialsHeaderValue(string scheme)");
		}
		#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpCredentialsHeaderValue.HttpCredentialsHeaderValue(string)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpCredentialsHeaderValue( string scheme,  string token) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpCredentialsHeaderValue", "HttpCredentialsHeaderValue.HttpCredentialsHeaderValue(string scheme, string token)");
		}
		#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpCredentialsHeaderValue.HttpCredentialsHeaderValue(string, string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Parameters.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Scheme.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpCredentialsHeaderValue.Token.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpCredentialsHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpCredentialsHeaderValue.ToString%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpCredentialsHeaderValue Parse( string input)
		{
			throw new global::System.NotImplementedException("The member HttpCredentialsHeaderValue HttpCredentialsHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpCredentialsHeaderValue%20HttpCredentialsHeaderValue.Parse%28string%20input%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( string input, out global::Windows.Web.Http.Headers.HttpCredentialsHeaderValue credentialsHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpCredentialsHeaderValue.TryParse(string input, out HttpCredentialsHeaderValue credentialsHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpCredentialsHeaderValue.TryParse%28string%20input%2C%20out%20HttpCredentialsHeaderValue%20credentialsHeaderValue%29");
		}
		#endif
	}
}
