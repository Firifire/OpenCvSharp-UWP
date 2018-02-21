using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        [DllImport(DllExtern)]
        public static extern IntPtr features2d_MSER_create(int delta, int minArea, int maxArea,
                                                        double maxVariation, double minDiversity, int maxEvolution,
                                                        double areaThreshold, double minMargin, int edgeBlurSize);
        [DllImport(DllExtern)]
        public static extern void features2d_Ptr_MSER_delete(IntPtr ptr);
        [DllImport(DllExtern)]
        public static extern void features2d_MSER_detect(IntPtr obj, IntPtr image, out IntPtr msers, IntPtr mask);
        [DllImport(DllExtern)]
        public static extern IntPtr features2d_MSER_info(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr features2d_Ptr_MSER_get(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern void features2d_MSER_detectRegions(
            IntPtr obj, IntPtr image,
            IntPtr msers,
            IntPtr bboxes);

        [DllImport(DllExtern)]
        public static extern void features2d_MSER_setDelta(IntPtr obj, int delta);
        [DllImport(DllExtern)]
        public static extern int features2d_MSER_getDelta(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void features2d_MSER_setMinArea(IntPtr obj, int minArea);
        [DllImport(DllExtern)]
        public static extern int features2d_MSER_getMinArea(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void features2d_MSER_setMaxArea(IntPtr obj, int maxArea);
        [DllImport(DllExtern)]
        public static extern int features2d_MSER_getMaxArea(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void features2d_MSER_setPass2Only(IntPtr obj, int f);
        [DllImport(DllExtern)]
        public static extern int features2d_MSER_getPass2Only(IntPtr obj);
    }
}