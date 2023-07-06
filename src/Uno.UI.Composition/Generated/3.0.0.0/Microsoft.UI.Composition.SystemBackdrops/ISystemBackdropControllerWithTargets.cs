#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.SystemBackdrops
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ISystemBackdropControllerWithTargets : global::Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController,global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Composition.SystemBackdrops.SystemBackdropState State
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets.State.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool AddSystemBackdropTarget( global::Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop systemBackdropTarget);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void RemoveAllSystemBackdropTargets();
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool RemoveSystemBackdropTarget( global::Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop systemBackdropTarget);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetSystemBackdropConfiguration( global::Microsoft.UI.Composition.SystemBackdrops.SystemBackdropConfiguration configuration);
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets.StateChanged.add
		// Forced skipping of method Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets.StateChanged.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		 event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets, object> StateChanged;
		#endif
	}
}
