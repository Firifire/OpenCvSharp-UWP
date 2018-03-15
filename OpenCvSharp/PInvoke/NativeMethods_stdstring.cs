using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern IntPtr string_new1();

        [DllImport(DllExtern, CharSet = CharSet.Ansi)]
        public static extern IntPtr string_new2([MarshalAs(UnmanagedType.LPStr)] string str);

        [DllImport(DllExtern)]
        public static extern void string_delete(IntPtr s);

        [DllImport(DllExtern)]
        public static extern unsafe sbyte* string_c_str(IntPtr s);

        [DllImport(DllExtern)]
        public static extern IntPtr string_size(IntPtr s);
    }
}