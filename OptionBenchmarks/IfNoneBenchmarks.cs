
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using LanguageExt;
using Microsoft.Extensions.Options;

namespace OptionBenchmarks;
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class IfNoneBenchmarks
{
    private readonly Option<string> strNone = Option<string>.None;
    private readonly Option<string[]> arrNone = Option<string[]>.None;


    private static readonly Func<string?> nullStrFun = () => default(string?);
    private static readonly Func<string[]?> nullStrArrFun = () => default(string[]?);

    [Benchmark(Baseline =true)]
    public void StrDefault()
    {
        string? nulStr = strNone.IfNoneUnsafe(default(string?));
    }
    
    [Benchmark]
    public void StrLambda()
    {
        string? nulStr = strNone.IfNoneUnsafe(() => null);
    }

    [Benchmark]
    public void StrLambdaStatic()
    {
        string? nulStr = strNone.IfNoneUnsafe(nullStrFun);
    }

    [Benchmark]
    public void StrArrDefault()
    {
        string[]? nulStrArr = arrNone.IfNoneUnsafe(default(string[]?));
    }

    [Benchmark]
    public void StrArrLambda()
    {
        string[]? nulStrArr = arrNone.IfNoneUnsafe(() => null);
    }

    [Benchmark]
    public void StrArrLambdaStatic()
    {
        string[]? nulStrArr = arrNone.IfNoneUnsafe(nullStrArrFun);
    }






}