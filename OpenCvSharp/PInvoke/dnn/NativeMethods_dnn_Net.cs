using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern IntPtr dnn_Net_new();

        [DllImport(DllExtern)]
        public static extern void dnn_Net_delete(IntPtr net);

        [DllImport(DllExtern)]
        public static extern int dnn_Net_empty(IntPtr net);

        [DllImport(DllExtern)]
        public static extern int dnn_Net_getLayerId(IntPtr net, [MarshalAs(UnmanagedType.LPStr)] string layer);

        [DllImport(DllExtern)]
        public static extern void dnn_Net_getLayerNames(IntPtr net, IntPtr outVec);
        
        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void dnn_Net_connect1(
            IntPtr net, [MarshalAs(UnmanagedType.LPStr)] string outPin, [MarshalAs(UnmanagedType.LPStr)] string inpPin);

        [DllImport(DllExtern)]
        public static extern void dnn_Net_connect2(IntPtr net, int outLayerId, int outNum, int inpLayerId, int inpNum);

        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void dnn_Net_setInputsNames(IntPtr net, string[] inputBlobNames, int inputBlobNamesLength);

        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern IntPtr dnn_Net_forward1(IntPtr net, [MarshalAs(UnmanagedType.LPStr)] string outputName);

        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void dnn_Net_forward2(
            IntPtr net, IntPtr[] outputBlobs, int outputBlobsLength, [MarshalAs(UnmanagedType.LPStr)] string outputName);

        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void dnn_Net_forward3(
            IntPtr net, IntPtr[] outputBlobs, int outputBlobsLength, string[] outBlobNames, int outBlobNamesLength);

        [DllImport(DllExtern, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void dnn_Net_setInput(IntPtr net, IntPtr blob, [MarshalAs(UnmanagedType.LPStr)] string name);
    }
}
