using System;

#pragma warning disable 1591

namespace OpenCvSharp.Util
{
    internal enum OS
    {
        Windows,
        Unix
    }
    internal enum Runtime
    {
        DotNet,
        Mono
    }

    /// <summary>
    /// Provides information for the platform which the user is using 
    /// </summary>
    internal static class Platform
    {
        /// <summary>
        /// OS type
        /// </summary>
        public static readonly OS OS;
        /// <summary>
        /// Runtime type
        /// </summary>
        public static readonly Runtime Runtime;

        static Platform()
        {
            Runtime = (Type.GetType("Mono.Runtime") == null) ? Runtime.Mono : Runtime.DotNet;
        }
    }
}
