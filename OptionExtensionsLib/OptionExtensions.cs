using LanguageExt;

namespace OptionExtensionsLib;

public static class OptionExtensions
{
    public static A? NullOnNone<A>(this ref Option<A> option) where A : struct
    {
        return option.IsNone ? null : option.IfNone(default(A));
    }

    public static A? NullableOnNone<A>(this ref Option<A> option) where A : class
    {
        return option.IsNone ? null : option.IfNone(default(A)!);
    }

}
