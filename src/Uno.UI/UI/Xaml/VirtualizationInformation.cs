﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Uno;

namespace Windows.UI.Xaml
{
	/// <summary>
	/// Class that holds virtualization information. We do not create this class indiscriminately,
	/// but only for containers that happen to be virtualizing.
	/// </summary>
	internal sealed class VirtualizationInformation
	{
		private Flags _flags;

		/// <summary>
		/// Marks this as a container generated by, eg, a <see cref="Controls.Primitives.Selector"/>, rather than an element explicitly 
		/// defined in xaml.
		/// </summary>
		public bool IsGeneratedContainer
		{
			get => _flags.HasFlag(Flags.IsGeneratedContainer);
			set => SetFlag(Flags.IsGeneratedContainer, value);
		}

		/// <summary>
		/// Marks this as a container defined in the root of an ItemTemplate, so that it can be handled appropriately when recycled.
		/// </summary>
		public bool IsContainerFromTemplateRoot
		{
			get => _flags.HasFlag(Flags.IsContainerFromTemplateRoot);
			set => SetFlag(Flags.IsContainerFromTemplateRoot, value);
		}

		/// <summary>
		/// Marks this as an item being its own container
		/// </summary>
		public bool IsOwnContainer
		{
			get => _flags.HasFlag(Flags.IsOwnContainer);
			set => SetFlag(Flags.IsOwnContainer, value);
		}

		public Rect Bounds { get; set; }

		public Size MeasureSize { get; set; }

		private void SetFlag(Flags flag, bool value)
		{
			if (value)
			{
				_flags |= flag;
			}
			else
			{
				_flags &= ~flag;
			}
		}

		[Flags]
		private enum Flags
		{
			None,
			IsGeneratedContainer,
			IsContainerFromTemplateRoot,
			IsOwnContainer
		}
	}
}
