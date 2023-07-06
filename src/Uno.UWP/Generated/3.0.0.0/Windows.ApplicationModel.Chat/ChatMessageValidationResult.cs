#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ChatMessageValidationResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint? MaxPartCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ChatMessageValidationResult.MaxPartCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20ChatMessageValidationResult.MaxPartCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint? PartCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ChatMessageValidationResult.PartCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20ChatMessageValidationResult.PartCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint? RemainingCharacterCountInPart
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ChatMessageValidationResult.RemainingCharacterCountInPart is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20ChatMessageValidationResult.RemainingCharacterCountInPart");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Chat.ChatMessageValidationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ChatMessageValidationStatus ChatMessageValidationResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ChatMessageValidationStatus%20ChatMessageValidationResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageValidationResult.MaxPartCount.get
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageValidationResult.PartCount.get
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageValidationResult.RemainingCharacterCountInPart.get
		// Forced skipping of method Windows.ApplicationModel.Chat.ChatMessageValidationResult.Status.get
	}
}
