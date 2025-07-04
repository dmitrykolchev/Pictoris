// <copyright file="Direct2dFactory1{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class Direct2dFactory1<T> : Direct2dFactory<T>
        where T : unmanaged, ID2D1Factory1.Interface, INativeGuid
{
    internal Direct2dFactory1(T* factory) : base(factory)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice);
    public Device CreateDevice(Dxgi.Device dxgiDevice)
    {
        ID2D1Device* device;
        CheckResult(Native->CreateDevice(dxgiDevice.Native, &device));
        return new Device(device);
    }


    //[return: NativeTypeName("HRESULT")]
    //int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES1 *")] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle1** strokeStyle);
    public StrokeStyle1 CreateStrokeStyle(in StrokeStyleProperties1 strokeStyleProperties, Span<float> dashes)
    {
        ID2D1StrokeStyle1* strokeStyle;
        if (dashes.IsEmpty)
        {
            CheckResult(Native->CreateStrokeStyle(
                (D2D1_STROKE_STYLE_PROPERTIES1*)Unsafe.AsPointer(in strokeStyleProperties),
                null,
                0,
                &strokeStyle));
        }
        else
        {
            fixed (float* pDashes = dashes)
            {
                CheckResult(Native->CreateStrokeStyle(
                    (D2D1_STROKE_STYLE_PROPERTIES1*)Unsafe.AsPointer(in strokeStyleProperties),
                    pDashes,
                    (uint)dashes.Length,
                    &strokeStyle));
            }
        }
        return new StrokeStyle1(strokeStyle);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreatePathGeometry(ID2D1PathGeometry1** pathGeometry);
    public new PathGeometry1 CreatePathGeometry()
    {
        ID2D1PathGeometry1* result;
        CheckResult(Native->CreatePathGeometry(&result));
        return new PathGeometry1(result);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock);

    //[return: NativeTypeName("HRESULT")]
    //int CreateGdiMetafile(IStream* metafileStream, ID2D1GdiMetafile** metafile);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterEffectFromStream([NativeTypeName("const IID &")] Guid* classId, IStream* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged[Stdcall]<IUnknown**, int> effectFactory);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterEffectFromString([NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("PCWSTR")] char* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged[Stdcall]<IUnknown**, int> effectFactory);

    //[return: NativeTypeName("HRESULT")]
    //int UnregisterEffect([NativeTypeName("const IID &")] Guid* classId);

    //[return: NativeTypeName("HRESULT")]
    //int GetRegisteredEffects([NativeTypeName("CLSID *")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32 *")] uint* effectsReturned, [NativeTypeName("UINT32 *")] uint* effectsRegistered);

    //[return: NativeTypeName("HRESULT")]
    //int GetEffectProperties([NativeTypeName("const IID &")] Guid* effectId, ID2D1Properties** properties);

}
