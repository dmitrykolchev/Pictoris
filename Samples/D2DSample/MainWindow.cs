// <copyright file="MainWindow.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics;
using Managed.Graphics.Direct2d;
using Managed.Graphics.Dxgi;
using Managed.Graphics.Wic;
using Pictoris.Imaging;

namespace D2DSample;

public partial class MainWindow : Form
{
    private DxgiDevice? _dxgiDevice;
    private IDxgiSwapChain? _swapChain;
    private DxgiSurface? _surface;
    private WicImagingFactory2? _wicFactory;

    private Direct2dFactory1? _factory;
    private DeviceContext? _deviceContext;
    private Bitmap1? _bitmap;
    private SolidColorBrush? _brush;
    private Managed.Graphics.Direct2d.Bitmap? _picture;

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
        if (_deviceContext != null && _wicFactory != null && _picture == null)
        {
            var file1 = @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_07\JPEG\Large\3M6A7290_1 (Large).JPG"; //
            var bitmap1 = RgbBitmap.Load(_wicFactory, file1);
            var file2 = @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_07\JPEG\Large\3M6A7290_1 (Large)_1.JPG"; //
            var bitmap2 = RgbBitmap.Load(_wicFactory, file2);
            var bitmap3 = BitmapBlend.Difference(bitmap1, bitmap2);
            bitmap3._Log(MathF.E * 10);
            var bitmap4 = BitmapBlend.DarkerColor(bitmap3, bitmap1);
            var bitmap5 = BitmapBlend.Overlay(bitmap1, bitmap4);
            //var bitmap6 = RgbBitmap.Create(16, 16, ColorF.FromRGBA(1, 1, 1, 0.5f));
            //string fileName = @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_07\JPEG\3M6A7233.JPG";
            //bitmapF.Log();
            //BitmapOperations.Log(bitmap1, MathF.E * 4);
            var pictureF = bitmap5.CreateBitmap(_deviceContext);
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

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            e.Handled = true;
            Close();
        }
        base.OnKeyDown(e);
    }

    private void Render()
    {
        var renderTarget = _deviceContext!;

        renderTarget.BeginDraw();

        renderTarget.Clear(ColorF.FromKnown(KnownColors.Black));

        CreateGradient();
        var dstSize = renderTarget.Size;
        var bmpSize = _picture!.Size;

        renderTarget.DrawBitmap(_picture,
              new RectF(
                  (dstSize.Width - bmpSize.Width) / 2,
                  (dstSize.Height - bmpSize.Height) / 2,
                  bmpSize.Width,
                  bmpSize.Height));

        renderTarget.EndDraw();
        _swapChain!.Present(1, 0);
    }

    private unsafe void MainWindow_Load(object? sender, EventArgs e)
    {
        _dxgiDevice?.Dispose();

        _wicFactory = WicImagingFactory2.CreateFactory();

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

    private void Reset()
    {
        Invalidate();
    }
}
