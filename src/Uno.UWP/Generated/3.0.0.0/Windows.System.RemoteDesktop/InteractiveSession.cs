#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteDesktop
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class InteractiveSession 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsRemote
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool InteractiveSession.IsRemote is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20InteractiveSession.IsRemote");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteDesktop.InteractiveSession.IsRemote.get
	}
}
