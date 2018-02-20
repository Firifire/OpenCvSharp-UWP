using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern)]
        public static extern int ml_EM_getClustersNumber(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_EM_setClustersNumber(IntPtr obj, int val);

        [DllImport(DllExtern)]
        public static extern int ml_EM_getCovarianceMatrixType(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_EM_setCovarianceMatrixType(IntPtr obj, int val);

        [DllImport(DllExtern)]
        public static extern TermCriteria ml_EM_getTermCriteria(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void ml_EM_setTermCriteria(IntPtr obj, TermCriteria val);
        
        [DllImport(DllExtern)]
        public static extern IntPtr ml_EM_getWeights(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern IntPtr ml_EM_getMeans(IntPtr obj);
        
        [DllImport(DllExtern)]
        public static extern void ml_EM_getCovs(IntPtr obj, IntPtr covs);
        
        [DllImport(DllExtern)]
        public static extern Vec2d ml_EM_predict2(IntPtr model, IntPtr sample, IntPtr probs);
        [DllImport(DllExtern)]
        public static extern int ml_EM_trainEM(
            IntPtr obj, IntPtr samples, IntPtr logLikelihoods, IntPtr labels, IntPtr probs);
        [DllImport(DllExtern)]
        public static extern int ml_EM_trainE(
            IntPtr model, IntPtr samples, IntPtr means0, IntPtr covs0, IntPtr weights0,
            IntPtr logLikelihoods, IntPtr labels, IntPtr probs);
        [DllImport(DllExtern)]
        public static extern int ml_EM_trainM(
            IntPtr model, IntPtr samples, IntPtr probs0, IntPtr logLikelihoods, 
            IntPtr labels, IntPtr probs);

        [DllImport(DllExtern)]
        public static extern IntPtr ml_EM_create();
        [DllImport(DllExtern)]
        public static extern IntPtr ml_Ptr_EM_get(IntPtr ptr);
        [DllImport(DllExtern)]
        public static extern void ml_Ptr_EM_delete(IntPtr ptr);
    }
}