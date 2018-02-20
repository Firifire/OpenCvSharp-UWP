using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using OpenCvSharp.Util;

// ReSharper disable InconsistentNaming
#pragma warning disable 1591

namespace OpenCvSharp
{
    /// <summary>
    /// P/Invoke methods of OpenCV 2.x C++ interface
    /// </summary>
    public static partial class NativeMethods
    {
        /// <summary>
        /// Is tried P/Invoke once
        /// </summary>
        private static bool tried = false;

        public const string DllMsvcr = "msvcr120";
        public const string DllMsvcp = "msvcp120";

        public const string DllExtern = "OpenCvHololens";

        public const string Version = "310";

        private static readonly string[] RuntimeDllNames =
        {
            //DllVCRuntime,
            //DllMsvcp,
        };

        private static readonly string[] OpenCVDllNames =
        {
            //"opencv_world",
        };

        public const string DllFfmpegX86 = "opencv_ffmpeg" + Version;
        public const string DllFfmpegX64 = DllFfmpegX86 + "_64";
        
        /// <summary>
        /// Static constructor
        /// </summary>
        static NativeMethods()
        {
            //LoadLibraries(WindowsLibraryLoader.Instance.AdditionalPaths);

            // call cv to enable redirecting 
            TryPInvoke();
        }

        /// <summary>
        /// Load DLL files dynamically using Win32 LoadLibrary
        /// </summary>
        /// <param name="additionalPaths"></param>
        public static void LoadLibraries(IEnumerable<string> additionalPaths = null)
        {

        }

        /// <summary>
        /// Checks whether PInvoke functions can be called
        /// </summary>
        public static void TryPInvoke()
        {
            if (tried)
                return;
            tried = true;

            try
            {
                core_Mat_sizeof();
            }
            catch (DllNotFoundException e)
            {
                throw;
            }
            catch (BadImageFormatException e)
            {
                throw;
            }
            catch (Exception e)
            {
                Exception ex = e.InnerException ?? e;
                try{ Debug.WriteLine(ex.Message); }
                catch{}
                throw;
            }
        }

        /// <summary>
        /// Returns whether the OS is Windows or not
        /// </summary>
        /// <returns></returns>
        public static bool IsWindows()
        {
            return !IsUnix();
        }

        /// <summary>
        /// Returns whether the OS is *nix or not
        /// </summary>
        /// <returns></returns>
        public static bool IsUnix()
        {
            return false;
        }

        /// <summary>
        /// Returns whether the runtime is Mono or not
        /// </summary>
        /// <returns></returns>
        public static bool IsMono()
        {
            return (Type.GetType("Mono.Runtime") != null);
        }

        #region Error redirection
        /// <summary>
        /// Custom error handler to be thrown by OpenCV
        /// </summary>
        public static readonly CvErrorCallback ErrorHandlerThrowException =
            delegate(ErrorCode status, string funcName, string errMsg, string fileName, int line, IntPtr userdata)
            {
                try
                {
                    //cvSetErrStatus(CvStatus.StsOk);
                    return 0;
                }
                finally
                {

                    throw new OpenCVException(status, funcName, errMsg, fileName, line);
                }
            };

        /// <summary>
        /// Custom error handler to ignore all OpenCV errors
        /// </summary>
        public static readonly CvErrorCallback ErrorHandlerIgnorance =
            delegate(ErrorCode status, string funcName, string errMsg, string fileName, int line, IntPtr userdata)
            {
                //cvSetErrStatus(CvStatus.StsOk);
                return 0;
            };

        /// <summary>
        /// Default error handler
        /// </summary>
        public static CvErrorCallback ErrorHandlerDefault;
        #endregion
    }
}