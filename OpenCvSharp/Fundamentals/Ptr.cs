using System;
using System.Collections.Generic;
using OpenCvHololens.Face;
using OpenCvHololens.ML;
using OpenCvHololens.XFeatures2D;
using OpenCvHololens.XImgProc;

namespace OpenCvHololens
{
    /// <summary>
    /// Template class for smart reference-counting pointers
    /// </summary>
    public abstract class Ptr : DisposableCvObject
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ptr"></param>
        protected Ptr(IntPtr ptr)
        {
            this.ptr = ptr;
        }
        
        /// <summary>
        /// Returns Ptr&lt;T&gt;.get() pointer
        /// </summary>
        public abstract IntPtr Get();
    }
}
