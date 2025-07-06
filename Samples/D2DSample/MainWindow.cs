// <copyright file="MainWindow.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.Intrinsics;
using Managed.Graphics;
using Managed.Graphics.Direct2d;
using Managed.Graphics.Dxgi;
using Managed.Graphics.Wic;
using Dxgi = Managed.Graphics.Dxgi;

namespace D2DSample;

public partial class MainWindow : Form
{
    private Dxgi.DxgiDevice? _dxgiDevice;
    private Dxgi.IDxgiSwapChain? _swapChain;
    private Dxgi.DxgiSurface? _surface;
    private WicImagingFactory2? _wicFactory;

    private Direct2dFactory1? _factory;
    private DeviceContext? _deviceContext;
    private Bitmap1? _bitmap;
    private SolidColorBrush? _brush;

    private BitmapF? _gradient;

    private Managed.Graphics.Direct2d.Bitmap? _picture;
    private Managed.Graphics.Direct2d.Bitmap? _gradientBitmap;

    private float _time;
    private float _baseHue;

    public MainWindow()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.Opaque |
            ControlStyles.UserPaint, true);
        Load += MainWindow_Load;
        FormClosed += MainWindow_FormClosed;
        InitializeComponent();
        CreateGradient();
    }

    private void CreateGradient()
    {
        if (_deviceContext != null && _gradientBitmap == null && _wicFactory != null)
        {
            BitmapF bitmap = BitmapF.CreateBitmap(256, 256);
            var r = bitmap.GetChannel(BitmapChannel.Red);
            var g = bitmap.GetChannel(BitmapChannel.Green);
            var b = bitmap.GetChannel(BitmapChannel.Blue);
            var a = bitmap.GetChannel(BitmapChannel.Alpha);
            for (int i = 0; i < bitmap.Width * bitmap.Height; ++i)
            {
                r[i] = (float)(i % bitmap.Width) / (float)bitmap.Width;
                g[i] = 0;
                b[i] = (float)(i % bitmap.Width) / (float)bitmap.Width;
                a[i] = (float)(i % bitmap.Width) / (float)bitmap.Width;
            }
            byte[] buffer = new byte[bitmap.Width * bitmap.Height * 4];
            BitmapF.AssembleBGRA(buffer, r, g, b, a, bitmap.Width, bitmap.Height);
            _gradientBitmap = BitmapF.CreateBitmapFromRawData(_deviceContext, buffer, bitmap.Width, bitmap.Height);
            _gradient = bitmap;

            string fileName = @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_04\JPEG\3M6A7224_s.JPG"; //

            var bitmapF = BitmapF.SplitBitmap(_wicFactory, fileName);
            bitmapF.Log();
            var pictureF = bitmapF.CreateBitmap(_deviceContext);

            _picture = pictureF;
            //_picture = BitmapF.LoadBitmapFromFile(_wicFactory, _deviceContext, fileName);
        }
    }


    private void MainWindow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        CleanUp();
    }

    private void CleanUp()
    {
        _bitmap?.Dispose();
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
        //if (e.Button == MouseButtons.Right)
        //{
        //    timer1.Enabled = !timer1.Enabled;
        //}
        //else
        //{
        //    Close();
        //}

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

        renderTarget.Clear(ColorF.FromKnown(KnownColors.Black));

        CreateGradient();
        var dstSize = renderTarget.Size;
        var bmpSize = _picture!.Size;

        //renderTarget.DrawBitmap(_picture!);

        renderTarget.DrawBitmap(_picture,
              new RectF(
                  (dstSize.Width - bmpSize.Width) / 2,
                  (dstSize.Height - bmpSize.Height) / 2,
                  bmpSize.Width,
                  bmpSize.Height));


        //var copy = _task == null
        //    ? []
        //    : _task.Result;

        //_task = CreateGeometries(_time);

        //if (_time == 0.1f)
        //{
        //    renderTarget.Clear(ColorF.FromKnown(KnownColors.Black, 1f));
        //}

        //renderTarget.FillRectangle(new RectF(0, 0, ClientSize.Width, ClientSize.Height), _brush!);
        //for (var index = 0; index < copy.Count; ++index)
        //{
        //    var tuple = copy[index];
        //    using var geometry = tuple.Item1;
        //    using var brush = renderTarget.CreateSolidColorBrush(tuple.Item2.AdjustContrast(1.5f));
        //    renderTarget.DrawGeometry(geometry, brush, 0.1f);
        //}
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
        
        _wicFactory = WicImagingFactory2.CreateFactory();

        _dxgiDevice = Dxgi.DxgiDevice.CreateDevice();
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
            _brush = _deviceContext.CreateSolidColorBrush(ColorF.FromKnown(KnownColors.Black, 0.4f));
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
        _time = 0.1f;
        _points = null;
        var random = new Random((int)DateTime.Now.TimeOfDay.Ticks);
        _baseHue = (float)random.NextDouble();
        Invalidate();
    }
}
