// <copyright file="ControlPointArray.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics.Direct2d;

namespace D2DSample;

public class ControlPointArray
{
    private readonly Point2F[] _points;

    private ControlPointArray(int count)
    {
        _points = new Point2F[count];
    }

    public static ControlPointArray Generate(int count, float minX, float maxX, float minY, float maxY)
    {
        var p = new ControlPointArray(count);
        p.Generate(minX, maxX, minY, maxY);
        return p;
    }

    public IEnumerable<Point2F> Points
    {
        get { return _points; }
    }

    public int Count
    {
        get { return _points.Length; }
    }

    public ref Point2F this[int index]
    {
        get { return ref _points[index]; }
    }

    private void Generate(float minX, float maxX, float minY, float maxY)
    {
        var random = new Random();
        for (var index = 0; index < _points.Length; ++index)
        {
            _points[index].X = (float)(minX + (random.NextDouble() * (maxX - minX)));
            _points[index].Y = (float)(minY + (random.NextDouble() * (maxY - minY)));
        }
    }

    public ControlPointArray Reduce(float t)
    {
        var result = new ControlPointArray(Count - 1);
        var count = Count;
        for (var index = 0; index < count - 1; ++index)
        {
            var point1 = _points[index];
            var point2 = _points[index + 1];
            result[index].X = point1.X + ((point2.X - point1.X) * t);
            result[index].Y = point1.Y + ((point2.Y - point1.Y) * t);
        }
        return result;
    }

    public IGeometry CreateGeometry(Direct2dFactory1 factory)
    {
        var geometry = factory.CreatePathGeometry();

        using (var sink = geometry.Open())
        {
            sink.BeginFigure(_points[0], FigureBegin.Hollow);
            sink.AddLines(_points);
            sink.EndFigure(FigureEnd.Open);
            sink.Close();
        }
        var list = new IGeometry[_points.Length + 1];
        list[0] = geometry;

        for (var index = 0; index < _points.Length; ++index)
        {
            list[index + 1] = factory.CreateEllipseGeometry(new Ellipse(_points[index], 5, 5));
        }
        var group = factory.CreateGeometryGroup(FillMode.Winding, list);

        return group;
    }
}
