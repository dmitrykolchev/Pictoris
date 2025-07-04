// <copyright file="IGeometrySink.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public interface IGeometrySink : ISimplifiedGeometrySink
{
    void AddArc(in ArcSegment arc);
    void AddBezier(in BezierSegment bezier);
    void AddLine(Point2F point);
    void AddQuadraticBezier(in QuadraticBezierSegment bezier);
    void AddQuadraticBeziers(Span<QuadraticBezierSegment> beziers);
}
