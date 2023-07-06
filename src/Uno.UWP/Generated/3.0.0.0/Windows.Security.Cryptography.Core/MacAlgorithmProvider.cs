#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Cryptography.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MacAlgorithmProvider 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string AlgorithmName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MacAlgorithmProvider.AlgorithmName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MacAlgorithmProvider.AlgorithmName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MacLength
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint MacAlgorithmProvider.MacLength is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20MacAlgorithmProvider.MacLength");
			}
		}
		#endif
		// Forced skipping of method Windows.Security.Cryptography.Core.MacAlgorithmProvider.AlgorithmName.get
		// Forced skipping of method Windows.Security.Cryptography.Core.MacAlgorithmProvider.MacLength.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Core.CryptographicKey CreateKey( global::Windows.Storage.Streams.IBuffer keyMaterial)
		{
			throw new global::System.NotImplementedException("The member CryptographicKey MacAlgorithmProvider.CreateKey(IBuffer keyMaterial) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CryptographicKey%20MacAlgorithmProvider.CreateKey%28IBuffer%20keyMaterial%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Core.CryptographicHash CreateHash( global::Windows.Storage.Streams.IBuffer keyMaterial)
		{
			throw new global::System.NotImplementedException("The member CryptographicHash MacAlgorithmProvider.CreateHash(IBuffer keyMaterial) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CryptographicHash%20MacAlgorithmProvider.CreateHash%28IBuffer%20keyMaterial%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Cryptography.Core.MacAlgorithmProvider OpenAlgorithm( string algorithm)
		{
			throw new global::System.NotImplementedException("The member MacAlgorithmProvider MacAlgorithmProvider.OpenAlgorithm(string algorithm) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MacAlgorithmProvider%20MacAlgorithmProvider.OpenAlgorithm%28string%20algorithm%29");
		}
		#endif
	}
}
