using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern void ximgproc_FastHoughTransform(IntPtr src, IntPtr dst,
            int dstMatDepth, int angleRange, int op, int makeSkew);

        [DllImport(DllExtern)]
        public static extern Vec4i ximgproc_HoughPoint2Line(Point houghPoint, IntPtr srcImgInfo,
            int angleRange, int makeSkew, int rules);
    }
}