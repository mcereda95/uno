#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.DialProtocol
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DialDisconnectButtonClickedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.DialProtocol.DialDevice Device
		{
			get
			{
				throw new global::System.NotImplementedException("The member DialDevice DialDisconnectButtonClickedEventArgs.Device is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DialDevice%20DialDisconnectButtonClickedEventArgs.Device");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.DialProtocol.DialDisconnectButtonClickedEventArgs.Device.get
	}
}
