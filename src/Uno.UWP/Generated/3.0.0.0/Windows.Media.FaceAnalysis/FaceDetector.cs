#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.FaceAnalysis
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FaceDetector 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapSize MinDetectableFaceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapSize FaceDetector.MinDetectableFaceSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BitmapSize%20FaceDetector.MinDetectableFaceSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.FaceAnalysis.FaceDetector", "BitmapSize FaceDetector.MinDetectableFaceSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Imaging.BitmapSize MaxDetectableFaceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member BitmapSize FaceDetector.MaxDetectableFaceSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BitmapSize%20FaceDetector.MaxDetectableFaceSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.FaceAnalysis.FaceDetector", "BitmapSize FaceDetector.MaxDetectableFaceSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsSupported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FaceDetector.IsSupported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FaceDetector.IsSupported");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.Media.FaceAnalysis.DetectedFace>> DetectFacesAsync( global::Windows.Graphics.Imaging.SoftwareBitmap image)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<DetectedFace>> FaceDetector.DetectFacesAsync(SoftwareBitmap image) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CDetectedFace%3E%3E%20FaceDetector.DetectFacesAsync%28SoftwareBitmap%20image%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IList<global::Windows.Media.FaceAnalysis.DetectedFace>> DetectFacesAsync( global::Windows.Graphics.Imaging.SoftwareBitmap image,  global::Windows.Graphics.Imaging.BitmapBounds searchArea)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IList<DetectedFace>> FaceDetector.DetectFacesAsync(SoftwareBitmap image, BitmapBounds searchArea) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIList%3CDetectedFace%3E%3E%20FaceDetector.DetectFacesAsync%28SoftwareBitmap%20image%2C%20BitmapBounds%20searchArea%29");
		}
		#endif
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceDetector.MinDetectableFaceSize.get
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceDetector.MinDetectableFaceSize.set
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceDetector.MaxDetectableFaceSize.get
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceDetector.MaxDetectableFaceSize.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Media.FaceAnalysis.FaceDetector> CreateAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FaceDetector> FaceDetector.CreateAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CFaceDetector%3E%20FaceDetector.CreateAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Graphics.Imaging.BitmapPixelFormat> GetSupportedBitmapPixelFormats()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<BitmapPixelFormat> FaceDetector.GetSupportedBitmapPixelFormats() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CBitmapPixelFormat%3E%20FaceDetector.GetSupportedBitmapPixelFormats%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsBitmapPixelFormatSupported( global::Windows.Graphics.Imaging.BitmapPixelFormat bitmapPixelFormat)
		{
			throw new global::System.NotImplementedException("The member bool FaceDetector.IsBitmapPixelFormatSupported(BitmapPixelFormat bitmapPixelFormat) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20FaceDetector.IsBitmapPixelFormatSupported%28BitmapPixelFormat%20bitmapPixelFormat%29");
		}
		#endif
		// Forced skipping of method Windows.Media.FaceAnalysis.FaceDetector.IsSupported.get
	}
}
