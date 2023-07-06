#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class VideoEffects 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string VideoStabilization
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VideoEffects.VideoStabilization is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20VideoEffects.VideoStabilization");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.VideoEffects.VideoStabilization.get
	}
}
