#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUIDevicePairingActivatedEventArgs : global::Windows.ApplicationModel.Activation.IDevicePairingActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIDevicePairingActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20WebUIDevicePairingActivatedEventArgs.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIDevicePairingActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20WebUIDevicePairingActivatedEventArgs.PreviousExecutionState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIDevicePairingActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20WebUIDevicePairingActivatedEventArgs.SplashScreen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User WebUIDevicePairingActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20WebUIDevicePairingActivatedEventArgs.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.DeviceInformation DeviceInformation
		{
			get
			{
				throw new global::System.NotImplementedException("The member DeviceInformation WebUIDevicePairingActivatedEventArgs.DeviceInformation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DeviceInformation%20WebUIDevicePairingActivatedEventArgs.DeviceInformation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIDevicePairingActivatedEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivatedOperation%20WebUIDevicePairingActivatedEventArgs.ActivatedOperation");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.DeviceInformation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.ActivatedOperation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDevicePairingActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IDevicePairingActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
