#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SetVersionRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint CurrentVersion
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SetVersionRequest.CurrentVersion is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20SetVersionRequest.CurrentVersion");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint DesiredVersion
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SetVersionRequest.DesiredVersion is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20SetVersionRequest.DesiredVersion");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.SetVersionRequest.CurrentVersion.get
		// Forced skipping of method Windows.Storage.SetVersionRequest.DesiredVersion.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.SetVersionDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member SetVersionDeferral SetVersionRequest.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SetVersionDeferral%20SetVersionRequest.GetDeferral%28%29");
		}
		#endif
	}
}
