// <copyright file="MainWindow.xaml.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Windows;
using System.Windows.Media;
using Managed.Graphics;
using Managed.Graphics.Direct2d;
using Managed.Graphics.Dxgi;
using D2D = Managed.Graphics.Direct2d;
using Dxgi = Managed.Graphics.Dxgi;
using Forms = System.Windows.Forms;

namespace WpfGraphicsSample;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Forms.Control? _d2dControl;

    private Dxgi.DxgiDevice? _dxgiDevice;
    private Dxgi.IDxgiSwapChain? _swapChain;
    private Dxgi.DxgiSurface? _surface;

    private D2D.Direct2dFactory1? _factory;
    private D2D.DeviceContext? _deviceContext;
    private D2D.Bitmap1? _bitmap;

    private D2D.SolidColorBrush? _brush;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        _d2dControl = new Forms.Panel();
        host.Child = _d2dControl;
        _d2dControl.BackColor = System.Drawing.Color.Transparent;
        _d2dControl.Resize += _d2dControl_Resize;
        InitDirect2D();
        CompositionTarget.Rendering += OnRender;
    }

    private void _d2dControl_Resize(object? sender, EventArgs e)
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
        }
    }

    private void InitDirect2D()
    {
        _dxgiDevice = Dxgi.DxgiDevice.CreateDevice();
        _factory = Direct2dFactory1.CreateFactory(
            FactoryType.SingleThreaded);
        using (var device = _factory.CreateDevice(_dxgiDevice))
        {
            _deviceContext = device.CreateDeviceContext(DeviceContextOptions.None);
            using var adapter = _dxgiDevice.GetAdapter();
            using var factory = adapter.GetFactory<DxgiFactory2>();
            DxgiSwapChainDesc1 swapChainDesc = new()
            {
                Width = _d2dControl!.ClientSize.Width,
                Height = _d2dControl.ClientSize.Height,
                Format = DxgiFormat.B8G8R8A8_UNORM,
                Stereo = false,
                SampleDesc = new DxgiSampleDesc() { Count = 1, Quality = 0 },
                BufferUsage = DxgiUsage.RenderTargetOutput,
                BufferCount = 2,
                Scaling = DxgiScaling.None,
                SwapEffect = DxgiSwapEffect.FlipSequential,
                AlphaMode = DxgiAlphaMode.Unspecified
            };
            _swapChain = factory.CreateSwapChainForHwnd(_dxgiDevice, _d2dControl.Handle, in swapChainDesc);
            _swapChain.GetBuffer(0, out _surface);
            _bitmap = _deviceContext.CreateBitmapFromDxgiSurface(_surface, _deviceContext.DpiX, _deviceContext.DpiY);
            _deviceContext.SetTarget(_bitmap);
            _brush = _deviceContext.CreateSolidColorBrush(ColorF.FromKnown(KnownColors.Blue));
        }
    }

    private void OnRender(object? sender, EventArgs e)
    {
        if (_deviceContext == null)
        {
            return;
        }
        _deviceContext.BeginDraw();
        _deviceContext.Clear(ColorF.FromKnown(KnownColors.Black));
        _deviceContext.FillRectangle(new RectF(100, 100, 300, 300), _brush!);
        _deviceContext.FillRectangle(new RectF(150, 140, 300, 300), _brush!);
        bool result = _deviceContext.EndDraw();
        _swapChain!.Present(1, DxgiPresent.None);
    }

}
