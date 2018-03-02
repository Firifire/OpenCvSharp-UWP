using System;

namespace OpenCvHololens.Flann
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchParams : IndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checks"></param>
        /// <param name="eps"></param>
        /// <param name="sorted"></param>
        public SearchParams(int checks = 32, float eps = 0.0f, bool sorted = true)
            : base(null)
        {
            IntPtr p = NativeMethods.flann_Ptr_SearchParams_new(checks, eps, sorted ? 1 : 0);
            if (p == IntPtr.Zero)
                throw new OpenCvHololensException($"Failed to create {nameof(SearchParams)}");

            PtrObj = new Ptr(p);
            ptr = PtrObj.Get();
        }

        /// <summary>
        /// 
        /// </summary>
        protected SearchParams(OpenCvHololens.Ptr ptrObj)
            : base(ptrObj)
        {
        }

        internal new class Ptr : OpenCvHololens.Ptr
        {
            public Ptr(IntPtr ptr) : base(ptr)
            {
            }

            public override IntPtr Get()
            {
                var res = NativeMethods.flann_Ptr_SearchParams_get(ptr);
                GC.KeepAlive(this);
                return res;
            }

            protected override void DisposeUnmanaged()
            {
                NativeMethods.flann_Ptr_SearchParams_delete(ptr);
                base.DisposeUnmanaged();
            }
        }
    }
}
