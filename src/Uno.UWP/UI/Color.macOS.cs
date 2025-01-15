using System;
using CoreGraphics;
using ObjCRuntime;

namespace Windows.UI
{
	public partial struct Color : IFormattable
	{
		private static bool legacy = OperatingSystem.IsMacOSVersionAtLeast(10, 15);

		public static implicit operator AppKit.NSColor(Color color) => AppKit.NSColor.FromRgba(color.R, color.G, color.B, color.A);
		public static implicit operator CGColor(Color color)
		{
			if (legacy)
			{
				return AppKit.NSColor.FromRgba(color.R, color.G, color.B, color.A).CGColor;
			}
			else
			{
				return CGColor.CreateSrgb(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
			}
		}

		public static implicit operator Color(AppKit.NSColor color) => color.CGColor;

		public static implicit operator Color(CoreGraphics.CGColor color)
		{
			nfloat red, green, blue, alpha;

			nfloat[] components = color.Components;
			switch (components.Length)
			{
				case 2:
					red = components[0];
					green = components[0];
					blue = components[0];
					alpha = components[1];
					break;
				case 3:
					red = components[0];
					green = components[1];
					blue = components[2];
					alpha = 1f;
					break;
				case 4:
					red = components[0];
					green = components[1];
					blue = components[2];
					alpha = components[3];
					break;
				default:
					throw new Exception("Unsupported colorspace component length: " + components.Length);
			}

			return FromArgb((byte)(alpha * 255 + .5), (byte)(red * 255 + .5), (byte)(green * 255 + .5), (byte)(blue * 255 + .5));
		}
	}
}
