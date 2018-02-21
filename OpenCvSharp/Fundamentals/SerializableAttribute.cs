using System;

namespace OpenCvHololens
{
#if !DOTNET_FRAMEWORK
    /// <summary>
    /// Dummy System.Serializable
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SerializableAttribute : Attribute
    {
    }
#endif
}
