// <copyright file="ID2D1SimplifiedGeometrySinkNativeWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

[DynamicInterfaceCastableImplementation]
internal unsafe interface ID2D1SimplifiedGeometrySinkNativeWrapper
{
    static void SetFillMode(ID2D1SimplifiedGeometrySink* inst, D2D1_FILL_MODE fillMode)
    {
        inst->lpVtbl->SetFillMode(inst, fillMode);
    }

    static void SetSegmentFlags(ID2D1SimplifiedGeometrySink* inst, D2D1_PATH_SEGMENT vertexFlags)
    {
        inst->lpVtbl->SetSegmentFlags(inst, vertexFlags);
    }

    static void BeginFigure(ID2D1SimplifiedGeometrySink* inst, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        inst->lpVtbl->BeginFigure(inst, startPoint, figureBegin);
    }

    static unsafe void AddLines(ID2D1SimplifiedGeometrySink* inst, D2D_POINT_2F* points, uint pointsCount)
    {
        inst->lpVtbl->AddLines(inst, points, pointsCount);
    }

    static unsafe void AddBeziers(ID2D1SimplifiedGeometrySink* inst, D2D1_BEZIER_SEGMENT* beziers, uint beziersCount)
    {
        inst->lpVtbl->AddBeziers(inst, beziers, beziersCount);
    }

    static void EndFigure(ID2D1SimplifiedGeometrySink* inst, D2D1_FIGURE_END figureEnd)
    {
        inst->lpVtbl->EndFigure(inst, figureEnd);
    }

    static int Close(ID2D1SimplifiedGeometrySink* inst)
    {
        return inst->lpVtbl->Close(inst);
    }
}
