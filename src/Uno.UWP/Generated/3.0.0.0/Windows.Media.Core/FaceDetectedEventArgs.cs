#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FaceDetectedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Core.FaceDetectionEffectFrame ResultFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member FaceDetectionEffectFrame FaceDetectedEventArgs.ResultFrame is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=FaceDetectionEffectFrame%20FaceDetectedEventArgs.ResultFrame");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.FaceDetectedEventArgs.ResultFrame.get
	}
}
