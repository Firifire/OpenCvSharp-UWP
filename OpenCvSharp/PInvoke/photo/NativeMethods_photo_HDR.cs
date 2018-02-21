using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern IntPtr photo_createCalibrateDebevec(int samples, float lambda, int random);

        [DllImport(DllExtern)]
        public static extern IntPtr photo_createCalibrateRobertson(int maxIter, float threshold);

        [DllImport(DllExtern)]
        public static extern void photo_Ptr_CalibrateDebevec_delete(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void photo_Ptr_CalibrateRobertson_delete(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr photo_Ptr_CalibrateDebevec_get(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr photo_Ptr_CalibrateRobertson_get(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern void photo_CalibrateCRF_process(
            IntPtr obj, IntPtr[] srcImgs, int srcImgsLength, IntPtr dst, [In, MarshalAs(UnmanagedType.LPArray)] float[] times);
    }
}