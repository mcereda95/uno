#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppDisplayInfo 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Description
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppDisplayInfo.Description is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AppDisplayInfo.Description");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppDisplayInfo.DisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AppDisplayInfo.DisplayName");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.AppDisplayInfo.DisplayName.get
		// Forced skipping of method Windows.ApplicationModel.AppDisplayInfo.Description.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.RandomAccessStreamReference GetLogo( global::Windows.Foundation.Size size)
		{
			throw new global::System.NotImplementedException("The member RandomAccessStreamReference AppDisplayInfo.GetLogo(Size size) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RandomAccessStreamReference%20AppDisplayInfo.GetLogo%28Size%20size%29");
		}
		#endif
	}
}
