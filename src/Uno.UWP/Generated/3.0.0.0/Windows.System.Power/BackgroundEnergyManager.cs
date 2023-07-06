#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Power
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class BackgroundEnergyManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint ExcessiveUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.ExcessiveUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.ExcessiveUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint LowUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.LowUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.LowUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint MaxAcceptableUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.MaxAcceptableUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.MaxAcceptableUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint NearMaxAcceptableUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.NearMaxAcceptableUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.NearMaxAcceptableUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint NearTerminationUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.NearTerminationUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.NearTerminationUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint RecentEnergyUsage
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.RecentEnergyUsage is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.RecentEnergyUsage");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint RecentEnergyUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.RecentEnergyUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.RecentEnergyUsageLevel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static uint TerminationUsageLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BackgroundEnergyManager.TerminationUsageLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BackgroundEnergyManager.TerminationUsageLevel");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.LowUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.NearMaxAcceptableUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.MaxAcceptableUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.ExcessiveUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.NearTerminationUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.TerminationUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsage.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsageLevel.get
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsageIncreased.add
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsageIncreased.remove
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsageReturnedToLow.add
		// Forced skipping of method Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsageReturnedToLow.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<object> RecentEnergyUsageIncreased
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.BackgroundEnergyManager", "event EventHandler<object> BackgroundEnergyManager.RecentEnergyUsageIncreased");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.BackgroundEnergyManager", "event EventHandler<object> BackgroundEnergyManager.RecentEnergyUsageIncreased");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<object> RecentEnergyUsageReturnedToLow
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.BackgroundEnergyManager", "event EventHandler<object> BackgroundEnergyManager.RecentEnergyUsageReturnedToLow");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.BackgroundEnergyManager", "event EventHandler<object> BackgroundEnergyManager.RecentEnergyUsageReturnedToLow");
			}
		}
		#endif
	}
}
