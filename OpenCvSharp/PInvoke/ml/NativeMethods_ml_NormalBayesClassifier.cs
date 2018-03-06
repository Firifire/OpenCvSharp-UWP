using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern float ml_NormalBayesClassifier_predictProb(
            IntPtr obj, IntPtr inputs,
            IntPtr samples, IntPtr outputProbs, int flags);

        [DllImport(DllExtern)]
        public static extern IntPtr ml_NormalBayesClassifier_create();
        
        [DllImport(DllExtern)]
        public static extern void ml_Ptr_NormalBayesClassifier_delete(IntPtr obj);
        
        [DllImport(DllExtern)]
        public static extern IntPtr ml_Ptr_NormalBayesClassifier_get(IntPtr obj);

        [DllImport(DllExtern)]
        public static extern IntPtr ml_NormalBayesClassifier_load(string filePath);

        [DllImport(DllExtern)]
        public static extern IntPtr ml_NormalBayesClassifier_loadFromString(string strModel);
    }
}