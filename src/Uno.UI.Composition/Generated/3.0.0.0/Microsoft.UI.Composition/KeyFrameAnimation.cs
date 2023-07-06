#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class KeyFrameAnimation : global::Microsoft.UI.Composition.CompositionAnimation
	{
		// Skipping already declared property StopBehavior
		// Skipping already declared property IterationCount
		// Skipping already declared property IterationBehavior
		// Skipping already declared property Duration
		// Skipping already declared property DelayTime
		// Skipping already declared property KeyFrameCount
		// Skipping already declared property Direction
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.AnimationDelayBehavior DelayBehavior
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationDelayBehavior KeyFrameAnimation.DelayBehavior is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AnimationDelayBehavior%20KeyFrameAnimation.DelayBehavior");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.KeyFrameAnimation", "AnimationDelayBehavior KeyFrameAnimation.DelayBehavior");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.StopBehavior.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void InsertExpressionKeyFrame( float normalizedProgressKey,  string value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.KeyFrameAnimation", "void KeyFrameAnimation.InsertExpressionKeyFrame(float normalizedProgressKey, string value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void InsertExpressionKeyFrame( float normalizedProgressKey,  string value,  global::Microsoft.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.KeyFrameAnimation", "void KeyFrameAnimation.InsertExpressionKeyFrame(float normalizedProgressKey, string value, CompositionEasingFunction easingFunction)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.DelayTime.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.StopBehavior.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.DelayBehavior.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.DelayTime.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.Duration.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.Duration.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.IterationBehavior.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.IterationBehavior.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.IterationCount.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.IterationCount.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.KeyFrameCount.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.Direction.get
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.Direction.set
		// Forced skipping of method Microsoft.UI.Composition.KeyFrameAnimation.DelayBehavior.get
	}
}
