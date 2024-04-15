#nullable enable

using System;
using SkiaSharp;
using Windows.Foundation;

namespace Microsoft.UI.Composition;

partial class CompositionGeometricClip
{
	internal override Rect? GetBounds(Visual visual)
	{
		switch (Geometry)
		{
			case CompositionPathGeometry { Path.GeometrySource: SkiaGeometrySource2D geometrySource }:
				return geometrySource.Geometry.TightBounds.ToRect();

			case CompositionPathGeometry cpg:
				throw new InvalidOperationException($"Clipping with source {cpg.Path?.GeometrySource} is not supported");

			case null:
				return null;

			default:
				throw new InvalidOperationException($"Clipping with {Geometry} is not supported");
		}
	}

	internal override void Apply(SKCanvas canvas, Visual visual)
	{
		switch (Geometry)
		{
			case CompositionPathGeometry { Path.GeometrySource: SkiaGeometrySource2D geometrySource }:
				canvas.ClipPath(geometrySource.Geometry, antialias: true);
				break;

			case CompositionPathGeometry cpg:
				throw new InvalidOperationException($"Clipping with source {cpg.Path?.GeometrySource} is not supported");

			case null:
				// null is nop
				break;

			default:
				throw new InvalidOperationException($"Clipping with {Geometry} is not supported");
		}
	}
}
