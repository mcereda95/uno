#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.People
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EyesPose 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.Spatial.SpatialRay? Gaze
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialRay? EyesPose.Gaze is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpatialRay%3F%20EyesPose.Gaze");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsCalibrationValid
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EyesPose.IsCalibrationValid is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20EyesPose.IsCalibrationValid");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Perception.PerceptionTimestamp UpdateTimestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionTimestamp EyesPose.UpdateTimestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PerceptionTimestamp%20EyesPose.UpdateTimestamp");
			}
		}
		#endif
		// Forced skipping of method Windows.Perception.People.EyesPose.IsCalibrationValid.get
		// Forced skipping of method Windows.Perception.People.EyesPose.Gaze.get
		// Forced skipping of method Windows.Perception.People.EyesPose.UpdateTimestamp.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsSupported()
		{
			throw new global::System.NotImplementedException("The member bool EyesPose.IsSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20EyesPose.IsSupported%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Input.GazeInputAccessStatus> RequestAccessAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<GazeInputAccessStatus> EyesPose.RequestAccessAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CGazeInputAccessStatus%3E%20EyesPose.RequestAccessAsync%28%29");
		}
		#endif
	}
}
