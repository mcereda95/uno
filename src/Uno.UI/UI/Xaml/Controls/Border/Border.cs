﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Windows.UI.Xaml.Media.Animation;
using Uno.Disposables;
using Uno.UI.DataBinding;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Markup;
using Uno.UI.Xaml;
#if XAMARIN_ANDROID
using Android.Views;
using Android.Graphics;
using View = Android.Views.View;
using Font = Android.Graphics.Typeface;
#elif XAMARIN_IOS_UNIFIED
using View = UIKit.UIView;
using Color = UIKit.UIColor;
using Font = UIKit.UIFont;
using UIKit;
#elif XAMARIN_IOS
using View = MonoTouch.UIKit.UIView;
using Color = MonoTouch.UIKit.UIColor;
using Font = MonoTouch.UIKit.UIFont;
using MonoTouch.UIKit;
#elif __MACOS__
using View = AppKit.NSView;
using Color = Windows.UI.Color;
#else
using Color = System.Drawing.Color;
using View = Windows.UI.Xaml.UIElement;
#endif

namespace Windows.UI.Xaml.Controls
{
	[ContentProperty(Name = nameof(Child))]
	public partial class Border : FrameworkElement
	{

		/// <summary>        
		/// Support for the C# collection initializer style.
		/// Allows items to be added like this 
		/// new Border 
		/// {
		///    new Border()
		/// }
		/// </summary>
		/// <param name="view"></param>
		public
#if XAMARIN_IOS
			new
#endif
			void Add(View view)
		{
			Child = VisualTreeHelper.TryAdaptNative(view);
		}

		protected override bool IsSimpleLayout => true;

		private protected override Thickness GetBorderThickness() => BorderThickness;


		#region Child DependencyProperty

		public virtual UIElement Child
		{
			get => (UIElement)this.GetValue(ChildProperty);
			set => this.SetValue(ChildProperty, value);
		}

		public static DependencyProperty ChildProperty { get ; } =
			DependencyProperty.Register(
				"Child",
				typeof(UIElement),
				typeof(Border),
				new FrameworkPropertyMetadata(
					null,
					// Since this is a view, inheritance is handled through the visual tree, rather than via the property. We explicitly
					// disable the property-based propagation here to support the case where the Parent property is overridden to simulate
					// a different inheritance hierarchy, as is done for some controls with native styles.
					FrameworkPropertyMetadataOptions.ValueDoesNotInheritDataContext,
					(s, e) => ((Border)s)?.OnChildChanged((UIElement)e.OldValue, (UIElement)e.NewValue)
				)
			);

		protected void OnChildChanged(UIElement oldValue, UIElement newValue)
		{
			ReAttachChildTransitions(oldValue, newValue);

			OnChildChangedPartial(oldValue, newValue);
		}

		partial void OnChildChangedPartial(UIElement previousValue, UIElement newValue);

		#endregion

		#region CornerRadius
		private static CornerRadius GetCornerRadiusDefaultValue() => CornerRadius.None;

		[GeneratedDependencyProperty(ChangedCallback = true, Options = FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange)]
		public static DependencyProperty CornerRadiusProperty { get; } = CreateCornerRadiusProperty();

		public CornerRadius CornerRadius
		{
			get => GetCornerRadiusValue();
			set => SetCornerRadiusValue(value);
		}

		private void OnCornerRadiusChanged(CornerRadius oldValue, CornerRadius newValue)
		{
			OnCornerRadiusUpdatedPartial(oldValue, newValue);
		}

		partial void OnCornerRadiusUpdatedPartial(CornerRadius oldValue, CornerRadius newValue);
		#endregion

		#region ChildTransitions

		/// <summary>
		/// This is a Transition for a UIElement.
		/// </summary>
		public TransitionCollection ChildTransitions
		{
			get => (TransitionCollection)this.GetValue(ChildTransitionsProperty);
			set => this.SetValue(ChildTransitionsProperty, value);
		}

		// Using a DependencyProperty as the backing store for Transitions.  This enables animation, styling, binding, etc...
		public static DependencyProperty ChildTransitionsProperty { get ; } =
			DependencyProperty.Register("ChildTransitions", typeof(TransitionCollection), typeof(Border), new FrameworkPropertyMetadata(null));

		private void ReAttachChildTransitions(UIElement originalChild, UIElement child)
		{
			if (this.ChildTransitions == null)
			{
				return;
			}

			if (!(originalChild is IFrameworkElement oldTargetElement))
			{
				return;
			}

			foreach (var transition in this.ChildTransitions)
			{
				transition.DetachFromElement(oldTargetElement);
			}

			if (!(child is IFrameworkElement targetElement))
			{
				return;
			}

			foreach (var transition in this.ChildTransitions)
			{
				transition.AttachToElement(targetElement);
			}
		}


		#endregion

		#region Padding DependencyProperty
		private static Thickness GetPaddingDefaultValue() => Thickness.Empty;

		[GeneratedDependencyProperty(ChangedCallback = true, Options = FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange)]
		public static DependencyProperty PaddingProperty { get; } = CreatePaddingProperty();

		public Thickness Padding
		{
			get => GetPaddingValue();
			set => SetPaddingValue(value);
		}

		protected virtual void OnPaddingChanged(Thickness oldValue, Thickness newValue)
		{
			OnPaddingChangedPartial(oldValue, newValue);
		}

		partial void OnPaddingChangedPartial(Thickness oldValue, Thickness newValue);

		#endregion

		#region BorderThickness DependencyProperty
		private static Thickness GetBorderThicknessDefaultValue() => Thickness.Empty;

		[GeneratedDependencyProperty(ChangedCallback = true, Options = FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange)]
		public static DependencyProperty BorderThicknessProperty { get; } = CreateBorderThicknessProperty();

		public Thickness BorderThickness
		{
			get => GetBorderThicknessValue();
			set => SetBorderThicknessValue(value);
		}

		protected virtual void OnBorderThicknessChanged(Thickness oldValue, Thickness newValue)
		{
			OnBorderThicknessChangedPartial(oldValue, newValue);
		}

		partial void OnBorderThicknessChangedPartial(Thickness oldValue, Thickness newValue);

		#endregion

		#region BorderBrush Dependency Property


		private SerialDisposable _borderBrushColorChanged = new SerialDisposable();
		private SerialDisposable _borderBrushOpacityChanged = new SerialDisposable();

#if XAMARIN_ANDROID
		//This field is never accessed. It just exists to create a reference, because the DP causes issues with ImageBrush of the backing bitmap being prematurely garbage-collected. (Bug with ConditionalWeakTable? https://bugzilla.xamarin.com/show_bug.cgi?id=21620)
		private Brush _borderBrushStrongReference;
#endif

		public Brush BorderBrush
		{
			get { return (Brush)this.GetValue(BorderBrushProperty); }
			set
			{
				this.SetValue(BorderBrushProperty, value);

#if XAMARIN_ANDROID
				_borderBrushStrongReference = value;
#endif
			}
		}

		// Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
		public static DependencyProperty BorderBrushProperty { get ; } =
			DependencyProperty.Register(
				"BorderBrush",
				typeof(Brush),
				typeof(Border),
				new FrameworkPropertyMetadata(
					SolidColorBrushHelper.Transparent,
					FrameworkPropertyMetadataOptions.ValueInheritsDataContext,
					propertyChangedCallback: (s, e) => ((Border)s).OnBorderBrushChanged((Brush)e.OldValue, (Brush)e.NewValue)
				)
			);

		protected virtual void OnBorderBrushChanged(Brush oldValue, Brush newValue)
		{
			if (newValue is SolidColorBrush colorBrush)
			{
				_borderBrushColorChanged.Disposable = colorBrush.RegisterDisposablePropertyChangedCallback(
					SolidColorBrush.ColorProperty,
					(s, colorArg) => OnBorderBrushChangedPartial()
				);
				_borderBrushOpacityChanged.Disposable = colorBrush.RegisterDisposablePropertyChangedCallback(
					SolidColorBrush.OpacityProperty,
					(s, _) => OnBorderBrushChangedPartial()
				);
			}
			else if (newValue is GradientBrush gb)
			{
				_borderBrushColorChanged.Disposable = gb.RegisterDisposablePropertyChangedCallback(
					GradientBrush.FallbackColorProperty,
					(s, colorArg) => OnBorderBrushChangedPartial()
				);
				_borderBrushOpacityChanged.Disposable = gb.RegisterDisposablePropertyChangedCallback(
					GradientBrush.OpacityProperty,
					(s, _) => OnBorderBrushChangedPartial()
				);
			}
			else if (newValue is AcrylicBrush ab)
			{
				_borderBrushColorChanged.Disposable = ab.RegisterDisposablePropertyChangedCallback(
					AcrylicBrush.FallbackColorProperty,
					(s, colorArg) => OnBorderBrushChangedPartial());
				_borderBrushOpacityChanged.Disposable = ab.RegisterDisposablePropertyChangedCallback(
					AcrylicBrush.OpacityProperty,
					(s, arg) => OnBorderBrushChangedPartial());
			}
			else
			{
				_borderBrushColorChanged.Disposable = null;
				_borderBrushOpacityChanged.Disposable = null;
			}

			OnBorderBrushChangedPartial();
		}

		partial void OnBorderBrushChangedPartial();

		#endregion
	}
}
