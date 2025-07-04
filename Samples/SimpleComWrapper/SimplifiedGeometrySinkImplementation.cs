using Managed.Graphics.Direct2d;

namespace SimpleComWrapper;

public unsafe class SimplifiedGeometrySinkImplementation : ISimplifiedGeometrySink
{
    public SimplifiedGeometrySinkImplementation()
    {
    }

    public void AddBeziers(Span<BezierSegment> beziers)
    {
        Console.WriteLine(nameof(AddBeziers));
    }

    public void AddLines(Span<Point2F> points)
    {
        Console.WriteLine(nameof(AddLines)); 
    }

    public void BeginFigure(Point2F startPoint, FigureBegin figureBegin)
    {
        Console.WriteLine(nameof(BeginFigure));
    }

    public void Close()
    {
        Console.WriteLine(nameof(Close));
    }

    public void EndFigure(FigureEnd figureEnd)
    {
        Console.WriteLine(nameof(EndFigure));
    }

    public void SetFillMode(FillMode fillMode)
    {
        Console.WriteLine(nameof(SetFillMode));
    }

    public void SetSegmentFlags(PathSegment vertexFlags)
    {
        Console.WriteLine(nameof(vertexFlags));
    }
}
