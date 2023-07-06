#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDragProvider 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string DropEffect
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string[] DropEffects
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool IsGrabbed
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDragProvider.IsGrabbed.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDragProvider.DropEffect.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.IDragProvider.DropEffects.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple[] GetGrabbedItems();
		#endif
	}
}
