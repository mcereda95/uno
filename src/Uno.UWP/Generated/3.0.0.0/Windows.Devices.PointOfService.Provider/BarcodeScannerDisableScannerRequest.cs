#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerDisableScannerRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BarcodeScannerDisableScannerRequest.ReportCompletedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20BarcodeScannerDisableScannerRequest.ReportCompletedAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BarcodeScannerDisableScannerRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20BarcodeScannerDisableScannerRequest.ReportFailedAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync( int reason)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BarcodeScannerDisableScannerRequest.ReportFailedAsync(int reason) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20BarcodeScannerDisableScannerRequest.ReportFailedAsync%28int%20reason%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync( int reason,  string failedReasonDescription)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BarcodeScannerDisableScannerRequest.ReportFailedAsync(int reason, string failedReasonDescription) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20BarcodeScannerDisableScannerRequest.ReportFailedAsync%28int%20reason%2C%20string%20failedReasonDescription%29");
		}
		#endif
	}
}
