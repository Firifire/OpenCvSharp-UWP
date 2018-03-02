using System;

namespace OpenCvHololens
{
#if LANG_JP
/// <summary>
/// OpenCvHololensから投げられる例外
/// </summary>
#else
    /// <summary>
    /// The exception that is thrown by OpenCvHololens. 
    /// </summary>
#endif
    public class OpenCvHololensException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public OpenCvHololensException()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public OpenCvHololensException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public OpenCvHololensException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public OpenCvHololensException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
