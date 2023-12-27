using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace OptionBenchmarks
{
    internal static class Program
    {
        static void Main(string[] _)
        {
            BenchmarkRunner.Run<IfNoneBenchmarks>();
        }
    }
}
