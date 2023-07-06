#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContextMenuEventArgs : global::Microsoft.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContextMenuEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ContextMenuEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ContextMenuEventArgs", "bool ContextMenuEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double CursorLeft
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ContextMenuEventArgs.CursorLeft is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20ContextMenuEventArgs.CursorLeft");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double CursorTop
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ContextMenuEventArgs.CursorTop is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20ContextMenuEventArgs.CursorTop");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.Handled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.CursorLeft.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.CursorTop.get
	}
}
