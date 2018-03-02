using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCvHololens.Flann
{
#if LANG_JP
    /// <summary>
    /// ディスクにあらかじめ保存されたデータを読み出すために利用されます．
    /// </summary>
#else
    /// <summary>
    /// This object type is used for loading a previously saved index from the disk.
    /// </summary>
#endif
    public class SavedIndexParams : IndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public SavedIndexParams(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException(nameof(fileName));

            IntPtr p = NativeMethods.flann_Ptr_SavedIndexParams_new(fileName);
            if (p == IntPtr.Zero)
                throw new OpenCvHololensException($"Failed to create {nameof(SavedIndexParams)}");

            PtrObj = new Ptr(p);
            ptr = PtrObj.Get();
        }

        /// <summary>
        /// 
        /// </summary>
        protected SavedIndexParams(OpenCvHololens.Ptr ptrObj)
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
                var res = NativeMethods.flann_Ptr_SavedIndexParams_get(ptr);
                GC.KeepAlive(this);
                return res;
            }

            protected override void DisposeUnmanaged()
            {
                NativeMethods.flann_Ptr_SavedIndexParams_delete(ptr);
                base.DisposeUnmanaged();
            }
        }
    }
}
