#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionFrameSourcePropertyChangeResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object NewValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member object PerceptionFrameSourcePropertyChangeResult.NewValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20PerceptionFrameSourcePropertyChangeResult.NewValue");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionFrameSourcePropertyChangeStatus PerceptionFrameSourcePropertyChangeResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PerceptionFrameSourcePropertyChangeStatus%20PerceptionFrameSourcePropertyChangeResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeResult.Status.get
		// Forced skipping of method Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeResult.NewValue.get
	}
}
