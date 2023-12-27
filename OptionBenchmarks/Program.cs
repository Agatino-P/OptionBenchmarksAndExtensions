using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LanguageExt;
using OptionExtensionsLib;
using static OptionExtensionsLib.OptionNullExtensions;

namespace OptionBenchmarks;

internal static class Program
{
    static void Main(string[] _)
    {
        BenchmarkRunner.Run<IfNoneBenchmarks>();
    }
}
