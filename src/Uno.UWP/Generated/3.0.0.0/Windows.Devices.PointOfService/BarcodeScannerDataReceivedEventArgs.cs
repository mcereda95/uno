#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerDataReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.PointOfService.BarcodeScannerReport Report
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerReport BarcodeScannerDataReceivedEventArgs.Report is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BarcodeScannerReport%20BarcodeScannerDataReceivedEventArgs.Report");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs.Report.get
	}
}
