#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AdvancedPhotoControl 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.AdvancedPhotoMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AdvancedPhotoMode AdvancedPhotoControl.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AdvancedPhotoMode%20AdvancedPhotoControl.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Supported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AdvancedPhotoControl.Supported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AdvancedPhotoControl.Supported");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Devices.AdvancedPhotoMode> SupportedModes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<AdvancedPhotoMode> AdvancedPhotoControl.SupportedModes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CAdvancedPhotoMode%3E%20AdvancedPhotoControl.SupportedModes");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.AdvancedPhotoControl.Supported.get
		// Forced skipping of method Windows.Media.Devices.AdvancedPhotoControl.SupportedModes.get
		// Forced skipping of method Windows.Media.Devices.AdvancedPhotoControl.Mode.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Configure( global::Windows.Media.Devices.AdvancedPhotoCaptureSettings settings)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.AdvancedPhotoControl", "void AdvancedPhotoControl.Configure(AdvancedPhotoCaptureSettings settings)");
		}
		#endif
	}
}
