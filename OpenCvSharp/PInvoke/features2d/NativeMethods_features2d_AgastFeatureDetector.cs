using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        [DllImport(DllExtern)]
        public static extern void features2d_AGAST(IntPtr image, IntPtr keypoints,
            int threshold, int nonmaxSuppression, int type);

        [DllImport(DllExtern)]
        public static extern IntPtr features2d_AgastFeatureDetector_create(
            int threshold, int nonmaxSuppression, int type);

        [DllImport(DllExtern)]
        public static extern void features2d_Ptr_AgastFeatureDetector_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr features2d_Ptr_AgastFeatureDetector_get(IntPtr ptr);
        
        [DllImport(DllExtern)]
        public static extern void features2d_AgastFeatureDetector_setThreshold(IntPtr obj, int val);
        [DllImport(DllExtern)]
        public static extern int features2d_AgastFeatureDetector_getThreshold(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void features2d_AgastFeatureDetector_setNonmaxSuppression(IntPtr obj,int val);
        [DllImport(DllExtern)]
        public static extern int features2d_AgastFeatureDetector_getNonmaxSuppression(IntPtr obj);
        
        [DllImport(DllExtern)]
        public static extern void features2d_AgastFeatureDetector_setType(IntPtr obj, int val);
        [DllImport(DllExtern)]
        public static extern int features2d_AgastFeatureDetector_getType(IntPtr obj);
    }
}
