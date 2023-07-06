#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PurchaseResults 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string OfferId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PurchaseResults.OfferId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PurchaseResults.OfferId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ReceiptXml
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PurchaseResults.ReceiptXml is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PurchaseResults.ReceiptXml");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Store.ProductPurchaseStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member ProductPurchaseStatus PurchaseResults.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProductPurchaseStatus%20PurchaseResults.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid TransactionId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid PurchaseResults.TransactionId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20PurchaseResults.TransactionId");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Store.PurchaseResults.Status.get
		// Forced skipping of method Windows.ApplicationModel.Store.PurchaseResults.TransactionId.get
		// Forced skipping of method Windows.ApplicationModel.Store.PurchaseResults.ReceiptXml.get
		// Forced skipping of method Windows.ApplicationModel.Store.PurchaseResults.OfferId.get
	}
}
