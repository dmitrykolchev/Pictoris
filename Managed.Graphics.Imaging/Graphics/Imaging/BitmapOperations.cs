// <copyright file="BitmapOperations.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;

namespace Managed.Graphics.Imaging;

public static class BitmapOperations
{
    public static unsafe RgbBitmap _Log(this RgbBitmap bitmap, float maxValue)
    {
        CalcChannel(bitmap.R.AsSpan(), maxValue);
        CalcChannel(bitmap.G.AsSpan(), maxValue);
        CalcChannel(bitmap.B.AsSpan(), maxValue);

        static void CalcChannel(Span<float> buffer, float maxValue)
        {
            var max = MathF.Log(maxValue);
            TensorPrimitives.Multiply((ReadOnlySpan<float>)buffer, maxValue, buffer);
            TensorPrimitives.Log((ReadOnlySpan<float>)buffer, buffer);
            TensorPrimitives.Divide((ReadOnlySpan<float>)buffer, max, buffer);
            TensorPrimitives.Max((ReadOnlySpan<float>)buffer, 0, buffer);
            TensorPrimitives.Min((ReadOnlySpan<float>)buffer, 1, buffer);
        }
        return bitmap;
    }

    public static unsafe RgbBitmap _Invert(this RgbBitmap bitmap)
    {
        CalcChannel(bitmap.R.AsSpan());
        CalcChannel(bitmap.G.AsSpan());
        CalcChannel(bitmap.B.AsSpan());

        static void CalcChannel(Span<float> buffer)
        {
            TensorPrimitives.Subtract(1f, (ReadOnlySpan<float>)buffer, buffer);
        }
        return bitmap;
    }
}
