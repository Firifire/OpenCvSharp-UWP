using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        // BaseOCR

        [DllImport(DllExtern)]
        public static extern void text_BaseOCR_run1(
            IntPtr obj,
            IntPtr image,
            IntPtr outputText,
            IntPtr componentRects,
            IntPtr componentTexts,
            IntPtr componentConfidences,
            int componentLevel);

        [DllImport(DllExtern)]
        public static extern void text_BaseOCR_run2(
            IntPtr obj,
            IntPtr image,
            IntPtr mask,
            IntPtr outputText,
            IntPtr componentRects,
            IntPtr componentTexts,
            IntPtr componentConfidences,
            int componentLevel);

        // OCRTesseract

        [DllImport(DllExtern)]
        public static extern void text_OCRTesseract_run1(
            IntPtr obj,
            IntPtr image,
            IntPtr outputText,
            IntPtr componentRects,
            IntPtr componentTexts,
            IntPtr componentConfidences,
            int componentLevel);

        [DllImport(DllExtern)]
        public static extern void text_OCRTesseract_run2(
            IntPtr obj,
            IntPtr image,
            IntPtr mask,
            IntPtr outputText,
            IntPtr componentRects,
            IntPtr componentTexts,
            IntPtr componentConfidences,
            int componentLevel);

        [DllImport(DllExtern)]
        public static extern void text_OCRTesseract_run3(
            IntPtr obj,
            IntPtr image,
            int minConfidence,
            int componentLevel,
            IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void text_OCRTesseract_run4(
            IntPtr obj,
            IntPtr image,
            IntPtr mask,
            int minConfidence,
            int componentLevel,
            IntPtr dst);

        [DllImport(DllExtern)]
        public static extern void text_OCRTesseract_setWhiteList(
            IntPtr obj, 
            [MarshalAs(UnmanagedType.LPStr)] string charWhitelist);

        [DllImport(DllExtern)]
        public static extern IntPtr text_OCRTesseract_create(
            [MarshalAs(UnmanagedType.LPStr)] string datapath,
            [MarshalAs(UnmanagedType.LPStr)] string language,
            [MarshalAs(UnmanagedType.LPStr)] string charWhitelist,
            int oem,
            int psmode);

        [DllImport(DllExtern)]
        public static extern void text_Ptr_OCRTesseract_delete(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr text_OCRTesseract_get(IntPtr obj);
    }
}