#nullable enable

using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI.Core;
using Uno.Extensions;

namespace Windows.UI.Composition;

public partial class Compositor
{
	private bool _isDirty;

	internal ContainerVisual? RootVisual { get; set; }

	internal void Render(SKSurface surface)
	{
		_isDirty = false;

		if (RootVisual != null)
		{
			// TODO: Why are we enumerating children manually instead of just let the ContainerVisual do its job?
			var children = RootVisual.GetChildrenInRenderOrder();
			for (var i = 0; i < children.Count; i++)
			{
				children[i].Render(surface);
			}
		}
	}

	partial void InvalidateRenderPartial()
	{
		if (!_isDirty)
		{
			_isDirty = true;
			CoreWindow.QueueInvalidateRender();
		}
	}
}
