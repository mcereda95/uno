using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls;

public sealed partial class Border_CornerRadius : Page
{
	public Border_CornerRadius()
	{
		this.InitializeComponent();
		var asd = Resources["TestConverter"];

		// todo: you can remove all the button in the page too, no longer needed
	}

	private void DebugStuff(object sender, RoutedEventArgs e)
	{
		if (MyTextBox is TextBox tb)
		{
			var templateRoot = VisualTreeHelper.GetChild(tb, 0) as Grid; // ok
																		   //var vsgs = VisualStateManager.GetVisualStateGroups(templateRoot); // ok

			VisualStateManager.GetVisualStateGroups(templateRoot).ToList();
			//var commonVsg = vsgs.FirstOrDefault(x => x.Name == "CommonStates"); // break the binding
			//var commonVs = commonVsg?.CurrentState;
		}
	}
	private void SetText(object sender, RoutedEventArgs e)
	{
		if (sender is Button btn)
		{
			MyTextBox.Text = btn.Tag as string ?? "";
		}
	}
	private void EnterVS(object sender, RoutedEventArgs e)
	{
		if (sender is Button btn && btn.Tag is string state)
		{
			//FE::GoToElementStateCore(string, bool);
			//var method = typeof(FrameworkElement).GetMethod("GoToElementStateCore", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			//method?.Invoke(MyTextBox, new object[] { state, false });
			try
			{
				//(MyTextBox as TextBoxV2).GotoState(state);
				VisualStateManager.GoToState(MyTextBox, state, false);
			}
			catch (Exception e2)
			{
				e2.ToString();
			}
		}
	}
}
