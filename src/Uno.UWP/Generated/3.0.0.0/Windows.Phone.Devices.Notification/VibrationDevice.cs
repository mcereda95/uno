#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.Devices.Notification
{
	#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
	#endif
	public  partial class VibrationDevice 
	{
		#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Vibrate( global::System.TimeSpan duration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Phone.Devices.Notification.VibrationDevice", "void VibrationDevice.Vibrate(TimeSpan duration)");
		}
		#endif
		#if false || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Cancel()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Phone.Devices.Notification.VibrationDevice", "void VibrationDevice.Cancel()");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Phone.Devices.Notification.VibrationDevice GetDefault()
		{
			throw new global::System.NotImplementedException("The member VibrationDevice VibrationDevice.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=VibrationDevice%20VibrationDevice.GetDefault%28%29");
		}
		#endif
	}
}
