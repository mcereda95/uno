#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ModuleCommandResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Result
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer ModuleCommandResult.Result is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20ModuleCommandResult.Result");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.SendCommandStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member SendCommandStatus ModuleCommandResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SendCommandStatus%20ModuleCommandResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.ModuleCommandResult.Status.get
		// Forced skipping of method Windows.Media.Devices.ModuleCommandResult.Result.get
	}
}
