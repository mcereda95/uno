using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls;

public class UberTestConveter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, string language)
	{
		var textBox = value as TextBox;

		if (textBox is not null)
		{
			var noText = string.IsNullOrEmpty(textBox.Text);

			if (noText)
			{
				return $"No-Text: {DateTime.Now:mmss}";
			}

		}

		return $"Text: {DateTime.Now:mmss}";
	}

	public object ConvertBack(object value, Type targetType, object parameter, string language) => throw new NotImplementedException();
}
