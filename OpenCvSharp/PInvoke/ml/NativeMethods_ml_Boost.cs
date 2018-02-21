using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern int ml_Boost_getBoostType(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_Boost_setBoostType(IntPtr obj, int val);

        [DllImport(DllExtern)]
        public static extern int ml_Boost_getWeakCount(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_Boost_setWeakCount(IntPtr obj, int val);

        [DllImport(DllExtern)]
        public static extern double ml_Boost_getWeightTrimRate(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_Boost_setWeightTrimRate(IntPtr obj, double val);
        
        [DllImport(DllExtern)]
        public static extern IntPtr ml_Boost_create();

        [DllImport(DllExtern)]
        public static extern void ml_Ptr_Boost_delete(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr ml_Ptr_Boost_get(IntPtr obj);
    }
}