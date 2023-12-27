using LanguageExt;

namespace OptionExtensionsLib;

public static class OptionNullExtensions
{
    public static A? IfNoneNullable<A>(this Option<A> option) where A : struct => 
        option.IsNone ? null : option.IfNone(default(A));

    public static A? IfNoneNull<A>(this Option<A> option) => 
        option.IsNone ? default : option.IfNone(default(A)!);
}
