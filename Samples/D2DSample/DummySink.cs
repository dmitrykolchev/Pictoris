using Managed.Graphics.Direct2d;

namespace D2DSample;

internal class DummySink : IGeometrySink
{
    public void AddArc(in ArcSegment arc)
    {
        Console.WriteLine($"{nameof(AddArc)}: {arc}");
    }

    public void AddBezier(in BezierSegment bezier)
    {
        Console.WriteLine($"{nameof(AddBezier)}: {bezier}");
    }

    public void AddBeziers(Span<BezierSegment> beziers)
    {
        Console.WriteLine($"{nameof(AddBeziers)}: {beziers.Length}");
    }

    public void AddLine(Point2F point)
    {
        Console.WriteLine($"{nameof(AddLine)}: {point}");
    }

    public void AddLines(Span<Point2F> points)
    {
        Console.WriteLine($"{nameof(AddLines)}: {points.Length}");
    }

    public void AddQuadraticBezier(in QuadraticBezierSegment bezier)
    {
        Console.WriteLine($"{nameof(AddQuadraticBezier)}: {bezier}");
    }

    public void AddQuadraticBeziers(Span<QuadraticBezierSegment> beziers)
    {
        Console.WriteLine($"{nameof(AddQuadraticBeziers)}: {beziers.Length}");
    }

    public void BeginFigure(Point2F startPoint, FigureBegin figureBegin)
    {
        Console.WriteLine($"{nameof(BeginFigure)}: {startPoint} {figureBegin}");
    }

    public void Close()
    {
        Console.WriteLine($"{nameof(Close)}");
    }

    public void EndFigure(FigureEnd figureEnd)
    {
        Console.WriteLine($"{nameof(EndFigure)}: {figureEnd}");
    }

    public void SetFillMode(FillMode fillMode)
    {
        Console.WriteLine($"{nameof(SetFillMode)}: {fillMode}");
    }

    public void SetSegmentFlags(PathSegment vertexFlags)
    {
        Console.WriteLine($"{nameof(SetSegmentFlags)}: {vertexFlags}");
    }
}
