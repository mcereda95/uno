#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Cryptography.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class CryptographicEngine 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer SignHashedData( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.SignHashedData(CryptographicKey key, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.SignHashedData%28CryptographicKey%20key%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool VerifySignatureWithHashInput( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer signature)
		{
			throw new global::System.NotImplementedException("The member bool CryptographicEngine.VerifySignatureWithHashInput(CryptographicKey key, IBuffer data, IBuffer signature) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CryptographicEngine.VerifySignatureWithHashInput%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20signature%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IBuffer> DecryptAsync( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer iv)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IBuffer> CryptographicEngine.DecryptAsync(CryptographicKey key, IBuffer data, IBuffer iv) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIBuffer%3E%20CryptographicEngine.DecryptAsync%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20iv%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IBuffer> SignAsync( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IBuffer> CryptographicEngine.SignAsync(CryptographicKey key, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIBuffer%3E%20CryptographicEngine.SignAsync%28CryptographicKey%20key%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IBuffer> SignHashedDataAsync( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IBuffer> CryptographicEngine.SignHashedDataAsync(CryptographicKey key, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIBuffer%3E%20CryptographicEngine.SignHashedDataAsync%28CryptographicKey%20key%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer Encrypt( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer iv)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.Encrypt(CryptographicKey key, IBuffer data, IBuffer iv) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.Encrypt%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20iv%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer Decrypt( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer iv)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.Decrypt(CryptographicKey key, IBuffer data, IBuffer iv) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.Decrypt%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20iv%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Cryptography.Core.EncryptedAndAuthenticatedData EncryptAndAuthenticate( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer nonce,  global::Windows.Storage.Streams.IBuffer authenticatedData)
		{
			throw new global::System.NotImplementedException("The member EncryptedAndAuthenticatedData CryptographicEngine.EncryptAndAuthenticate(CryptographicKey key, IBuffer data, IBuffer nonce, IBuffer authenticatedData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EncryptedAndAuthenticatedData%20CryptographicEngine.EncryptAndAuthenticate%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20nonce%2C%20IBuffer%20authenticatedData%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer DecryptAndAuthenticate( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer nonce,  global::Windows.Storage.Streams.IBuffer authenticationTag,  global::Windows.Storage.Streams.IBuffer authenticatedData)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.DecryptAndAuthenticate(CryptographicKey key, IBuffer data, IBuffer nonce, IBuffer authenticationTag, IBuffer authenticatedData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.DecryptAndAuthenticate%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20nonce%2C%20IBuffer%20authenticationTag%2C%20IBuffer%20authenticatedData%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer Sign( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.Sign(CryptographicKey key, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.Sign%28CryptographicKey%20key%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool VerifySignature( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Storage.Streams.IBuffer data,  global::Windows.Storage.Streams.IBuffer signature)
		{
			throw new global::System.NotImplementedException("The member bool CryptographicEngine.VerifySignature(CryptographicKey key, IBuffer data, IBuffer signature) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CryptographicEngine.VerifySignature%28CryptographicKey%20key%2C%20IBuffer%20data%2C%20IBuffer%20signature%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Streams.IBuffer DeriveKeyMaterial( global::Windows.Security.Cryptography.Core.CryptographicKey key,  global::Windows.Security.Cryptography.Core.KeyDerivationParameters parameters,  uint desiredKeySize)
		{
			throw new global::System.NotImplementedException("The member IBuffer CryptographicEngine.DeriveKeyMaterial(CryptographicKey key, KeyDerivationParameters parameters, uint desiredKeySize) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20CryptographicEngine.DeriveKeyMaterial%28CryptographicKey%20key%2C%20KeyDerivationParameters%20parameters%2C%20uint%20desiredKeySize%29");
		}
		#endif
	}
}
