using System;

namespace OneOf
{
    public interface IOneOf
    {
        object Value { get; }
        Type OrigType { get; }
    }
}