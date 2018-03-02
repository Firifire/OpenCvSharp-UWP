using System;
using System.Runtime.InteropServices;
using OpenCvHololens.Tracking;

#pragma warning disable 1591

namespace OpenCvHololens
{
    static partial class NativeMethods
    {
        /*
        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Tracker_create(string trackerType);
        */

        [DllImport(DllExtern)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool tracking_Tracker_init(IntPtr obj, IntPtr image, Rect2d boundingBox);

        [DllImport(DllExtern)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool tracking_Tracker_update(IntPtr obj, IntPtr image, ref Rect2d boundingBox);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_Tracker_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_Tracker_get(IntPtr ptr);


        // TrackerKCF

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerKCF_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerKCF_create2(TrackerKCF.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerKCF_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerKCF_get(IntPtr ptr);


        // TrackerMIL

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerMIL_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerMIL_create2(TrackerMIL.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerMIL_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerMIL_get(IntPtr ptr);


        // TrackerBoosting

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerBoosting_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerBoosting_create2(TrackerBoosting.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerBoosting_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerBoosting_get(IntPtr ptr);


        // TrackerBoosting

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerMedianFlow_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerMedianFlow_create2(TrackerMedianFlow.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerMedianFlow_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerMedianFlow_get(IntPtr ptr);


        // TrackerTLD

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerTLD_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerTLD_create2(TrackerTLD.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerTLD_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerTLD_get(IntPtr ptr);


        // TrackerGOTURN

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_TrackerGOTURN_create1();

        [DllImport(DllExtern)]
        public static extern unsafe IntPtr tracking_TrackerGOTURN_create2(TrackerGOTURN.Params* parameters);

        [DllImport(DllExtern)]
        public static extern void tracking_Ptr_TrackerGOTURN_delete(IntPtr ptr);

        [DllImport(DllExtern)]
        public static extern IntPtr tracking_Ptr_TrackerGOTURN_get(IntPtr ptr);
    }
}