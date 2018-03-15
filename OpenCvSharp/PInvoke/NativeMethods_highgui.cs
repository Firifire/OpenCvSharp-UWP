using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_namedWindow([MarshalAs(UnmanagedType.LPStr)] string winname, int flags);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_destroyWindow([MarshalAs(UnmanagedType.LPStr)] string winName);
        [DllImport(DllExtern)]
        public static extern void highgui_destroyAllWindows();
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_imshow([MarshalAs(UnmanagedType.LPStr)] string winname, IntPtr mat);

        [DllImport(DllExtern)]
        public static extern int highgui_startWindowThread();
        [DllImport(DllExtern)]
        public static extern int highgui_waitKey(int delay);
        [DllImport(DllExtern)]
        public static extern int highgui_waitKeyEx(int delay);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_resizeWindow([MarshalAs(UnmanagedType.LPStr)] string winName, int width, int height);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_moveWindow([MarshalAs(UnmanagedType.LPStr)] string winName, int x, int y);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setWindowProperty([MarshalAs(UnmanagedType.LPStr)] string winName, int propId, double propValue);
        
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setWindowTitle([MarshalAs(UnmanagedType.LPStr)] string winname, [MarshalAs(UnmanagedType.LPStr)] string title);
        
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern double highgui_getWindowProperty([MarshalAs(UnmanagedType.LPStr)] string winName, int propId);

        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setMouseCallback(string winName, [MarshalAs(UnmanagedType.FunctionPtr)] CvMouseCallback onMouse, IntPtr userData);
        
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int highgui_getMouseWheelDelta(int flags);

        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int highgui_createTrackbar([MarshalAs(UnmanagedType.LPStr)] string trackbarName, [MarshalAs(UnmanagedType.LPStr)] string winName,
            ref int value, int count, IntPtr onChange, IntPtr userData);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int highgui_createTrackbar([MarshalAs(UnmanagedType.LPStr)] string trackbarName, [MarshalAs(UnmanagedType.LPStr)] string winName,
            ref int value, int count, [MarshalAs(UnmanagedType.FunctionPtr)] CvTrackbarCallback2 onChange, IntPtr userData);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int highgui_getTrackbarPos([MarshalAs(UnmanagedType.LPStr)] string trackbarName, [MarshalAs(UnmanagedType.LPStr)] string winName);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setTrackbarPos(string trackbarName, string winName, int pos);

        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setTrackbarMax([MarshalAs(UnmanagedType.LPStr)] string trackbarname, [MarshalAs(UnmanagedType.LPStr)] string winname, int maxval);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void highgui_setTrackbarMin([MarshalAs(UnmanagedType.LPStr)] string trackbarname, [MarshalAs(UnmanagedType.LPStr)] string winname, int minval);

        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int highgui_createButton([MarshalAs(UnmanagedType.LPStr)] string barName, IntPtr onChange, IntPtr userdata, int type, int initialButtonState);
    }
}