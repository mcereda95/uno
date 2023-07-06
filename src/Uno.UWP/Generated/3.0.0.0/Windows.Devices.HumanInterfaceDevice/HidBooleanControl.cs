#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.HumanInterfaceDevice
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HidBooleanControl 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsActive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HidBooleanControl.IsActive is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HidBooleanControl.IsActive");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.HumanInterfaceDevice.HidBooleanControl", "bool HidBooleanControl.IsActive");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription ControlDescription
		{
			get
			{
				throw new global::System.NotImplementedException("The member HidBooleanControlDescription HidBooleanControl.ControlDescription is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HidBooleanControlDescription%20HidBooleanControl.ControlDescription");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint HidBooleanControl.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20HidBooleanControl.Id");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort UsageId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort HidBooleanControl.UsageId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20HidBooleanControl.UsageId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort UsagePage
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort HidBooleanControl.UsagePage is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20HidBooleanControl.UsagePage");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.Id.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.UsagePage.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.UsageId.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.IsActive.get
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.IsActive.set
		// Forced skipping of method Windows.Devices.HumanInterfaceDevice.HidBooleanControl.ControlDescription.get
	}
}
