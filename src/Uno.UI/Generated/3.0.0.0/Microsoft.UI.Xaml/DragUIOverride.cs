#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DragUIOverride 
	{
		// Skipping already declared property IsGlyphVisible
		// Skipping already declared property IsContentVisible
		// Skipping already declared property IsCaptionVisible
		// Skipping already declared property Caption
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.Caption.get
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.Caption.set
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsContentVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsContentVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsCaptionVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsCaptionVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsGlyphVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.DragUIOverride.IsGlyphVisible.set
		// Skipping already declared method Microsoft.UI.Xaml.DragUIOverride.Clear()
		// Skipping already declared method Microsoft.UI.Xaml.DragUIOverride.SetContentFromBitmapImage(Microsoft.UI.Xaml.Media.Imaging.BitmapImage)
		// Skipping already declared method Microsoft.UI.Xaml.DragUIOverride.SetContentFromBitmapImage(Microsoft.UI.Xaml.Media.Imaging.BitmapImage, Windows.Foundation.Point)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetContentFromSoftwareBitmap( global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DragUIOverride", "void DragUIOverride.SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetContentFromSoftwareBitmap( global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap,  global::Windows.Foundation.Point anchorPoint)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DragUIOverride", "void DragUIOverride.SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint)");
		}
		#endif
	}
}
