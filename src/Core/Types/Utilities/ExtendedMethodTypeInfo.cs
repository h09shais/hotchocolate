using System.Collections.Generic;
using System.Reflection;

#nullable enable

namespace HotChocolate.Utilities
{
    public sealed class ExtendedMethodTypeInfo : IExtendedMethodTypeInfo
    {
        public ExtendedMethodTypeInfo(
            IExtendedType returnType,
            IReadOnlyDictionary<ParameterInfo, IExtendedType> parameterTypes)
        {
            ReturnType = returnType;
            ParameterTypes = parameterTypes;
        }

        public IExtendedType ReturnType { get; }

        public IReadOnlyDictionary<ParameterInfo, IExtendedType> ParameterTypes { get; }
    }
}