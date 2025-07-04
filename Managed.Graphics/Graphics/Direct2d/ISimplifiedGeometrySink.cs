// <copyright file="ISimplifiedGeometrySink.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public interface ISimplifiedGeometrySink
{
    void AddBeziers(Span<BezierSegment> beziers);
    void AddLines(Span<Point2F> points);
    void BeginFigure(Point2F startPoint, FigureBegin figureBegin);
    void Close();
    void EndFigure(FigureEnd figureEnd);
    void SetFillMode(FillMode fillMode);
    void SetSegmentFlags(PathSegment vertexFlags);
}
