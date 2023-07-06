#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HolographicFrameRenderingReport 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Holographic.HolographicFrameId FrameId
		{
			get
			{
				throw new global::System.NotImplementedException("The member HolographicFrameId HolographicFrameRenderingReport.FrameId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HolographicFrameId%20HolographicFrameRenderingReport.FrameId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MissedLatchCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint HolographicFrameRenderingReport.MissedLatchCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20HolographicFrameRenderingReport.MissedLatchCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan SystemRelativeActualGpuFinishTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan HolographicFrameRenderingReport.SystemRelativeActualGpuFinishTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20HolographicFrameRenderingReport.SystemRelativeActualGpuFinishTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan SystemRelativeFrameReadyTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan HolographicFrameRenderingReport.SystemRelativeFrameReadyTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20HolographicFrameRenderingReport.SystemRelativeFrameReadyTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan SystemRelativeTargetLatchTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan HolographicFrameRenderingReport.SystemRelativeTargetLatchTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20HolographicFrameRenderingReport.SystemRelativeTargetLatchTime");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFrameRenderingReport.FrameId.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFrameRenderingReport.MissedLatchCount.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFrameRenderingReport.SystemRelativeFrameReadyTime.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFrameRenderingReport.SystemRelativeActualGpuFinishTime.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFrameRenderingReport.SystemRelativeTargetLatchTime.get
	}
}
