// <copyright file="MainWindow.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.Intrinsics;
using Managed.Graphics;
using Managed.Graphics.Direct2d;
using Managed.Graphics.Dxgi;

namespace D2DSample;

public partial class MainWindow : Form
{
    private DxgiDevice? _dxgiDevice;
    private IDxgiSwapChain? _swapChain;
    private DxgiSurface? _surface;

    private Direct2dFactory1? _factory;
    private DeviceContext? _deviceContext;
    private SolidColorBrush? _brush;
    private Bitmap1? _bitmap;

    private float _time;
    private float _baseHue;
    private bool _reset = true;

    public MainWindow()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.Opaque |
            ControlStyles.UserPaint, true);
        Load += MainWindow_Load;
        FormClosed += MainWindow_FormClosed;
        InitializeComponent();
    }

    private void MainWindow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        CleanUp();
    }

    private void CleanUp()
    {
        _brush?.Dispose();
        _deviceContext?.Dispose();
        _surface?.Dispose();
        _swapChain?.Dispose();
        _dxgiDevice?.Dispose();
        _factory?.Dispose();
    }

    private ControlPointArray? _points;

    public ControlPointArray Points
    {
        get
        {
            if (_points == null)
            {
                _points = ControlPointArray.Generate(90, 0, ClientSize.Width, 0, ClientSize.Height);
            }

            return _points;
        }
    }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            timer1.Enabled = !timer1.Enabled;
        }
        else
        {
            Close();
        }

        base.OnMouseDown(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            e.Handled = true;
            Close();
        }
        base.OnKeyDown(e);
    }

    private Task<List<Tuple<IGeometry, ColorF>>>? _task;

    private void Render()
    {
        var renderTarget = _deviceContext!;

        renderTarget.BeginDraw();

        if (_reset)
        {
            renderTarget.Clear(ColorF.FromKnown(KnownColors.Black));
            _reset = false;
        }

        var dstSize = renderTarget.Size;

        var copy = _task == null
            ? []
            : _task.Result;

        _task = CreateGeometries(_time);

        if (_time == 0.1f)
        {
            renderTarget.Clear(ColorF.FromKnown(KnownColors.Black, 1f));
        }

        renderTarget.FillRectangle(new RectF(0, 0, ClientSize.Width, ClientSize.Height), _brush!);
        for (var index = 0; index < copy.Count; ++index)
        {
            var tuple = copy[index];
            using var geometry = tuple.Item1;
            using var brush = renderTarget.CreateSolidColorBrush(tuple.Item2.AdjustContrast(1.5f));
            renderTarget.DrawGeometry(geometry, brush, 0.15f);
        }
        renderTarget.EndDraw();
        _swapChain!.Present(1, 0);
        _time += 0.001f;
    }

    private Task<List<Tuple<IGeometry, ColorF>>> CreateGeometries(float time)
    {
        return Task.Run(() =>
        {
            var temp = Points;
            var count = Points.Count;
            var geometries = new List<Tuple<IGeometry, ColorF>>();
            for (var index = 0; index < count - 1; ++index)
            {
                var hue = (_baseHue + ((index + 1) / (float)(count + 1))) % 1;
                var hsv = Vector128.Create([hue, 1.0f, 1f, 1f]);
                var rgba = ColorF.FromHSV(hsv);
                var array = temp.Reduce(time);
                geometries.Add(new Tuple<IGeometry, ColorF>(array.CreateGeometry(_factory!), rgba));
                temp = array;
            }
            return geometries;
        });
    }

    private unsafe void MainWindow_Load(object? sender, EventArgs e)
    {
        _dxgiDevice?.Dispose();

        _dxgiDevice = DxgiDevice.CreateDevice();
        _factory = Direct2dFactory1.CreateFactory(
            FactoryType.SingleThreaded);
        using (var device = _factory.CreateDevice(_dxgiDevice))
        {
            _deviceContext = device.CreateDeviceContext(DeviceContextOptions.None);
            using var adapter = _dxgiDevice.GetAdapter();
            using var factory = adapter.GetFactory<DxgiFactory2>();
            _swapChain = factory.CreateSwapChainForHwnd(_dxgiDevice, Handle);
            _dxgiDevice.MaximumFrameLatency = 1;

            _swapChain.GetBuffer(0, out _surface);
            _bitmap = _deviceContext.CreateBitmapFromDxgiSurface(_surface, _deviceContext.DpiX, _deviceContext.DpiY);
            _deviceContext.SetTarget(_bitmap);
            _brush = _deviceContext.CreateSolidColorBrush(ColorF.FromKnown(KnownColors.Black, 0.1f));
        }
    }

    protected override void OnResize(EventArgs e)
    {
        if (_deviceContext != null)
        {
            _deviceContext.ClearTarget();
            _bitmap?.Dispose();
            _surface?.Dispose();

            _swapChain!.ResizeBuffers();

            _swapChain.GetBuffer(0, out _surface);
            _bitmap = _deviceContext.CreateBitmapFromDxgiSurface(_surface, _deviceContext.DpiX, _deviceContext.DpiY);
            _deviceContext.SetTarget(_bitmap);

            Reset();
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Render();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (_time > 0.9f)
        {
            Reset();
        }
        Invalidate();
    }

    private void Reset()
    {
        _reset = true;
        _time = 0.1f;
        _points = null;
        var random = new Random((int)DateTime.Now.TimeOfDay.Ticks);
        _baseHue = (float)random.NextDouble();
        Invalidate();
    }
}
