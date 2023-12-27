
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using LanguageExt;
using OptionExtensionsLib;

namespace OptionBenchmarks;
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class IfNoneBenchmarks
{
    private static readonly Func<string?> _nullStrFun = () => default;

    private readonly Option<string> _strNone = Option<string>.None;

    [Benchmark(Baseline = true)]
    public void StrNoneDefault() => _strNone.IfNoneUnsafe(default(string?));

    [Benchmark]
    public void StrNoneLambda() => _strNone.IfNoneUnsafe(() => null);

    [Benchmark]
    public void StrNoneLambdaStatic() => _strNone.IfNoneUnsafe(_nullStrFun);

    [Benchmark]
    public void StrNoneExtension() => _strNone.IfNoneNull();

    private readonly Option<string> _strSome = Option<string>.Some("A string");

    [Benchmark]
    public void StrSomeDefault() => _strSome.IfNoneUnsafe(default(string?));

    [Benchmark]
    public void StrSomeLambda() => _strSome.IfNoneUnsafe(() => null);

    [Benchmark]
    public void StrSomeLambdaStatic() => _strSome.IfNoneUnsafe(_nullStrFun);

    [Benchmark]
    public void StrSomeExtension() => _strSome.IfNoneNull();

    //String Array

    private static readonly Func<string[]?> _nullStrArrFun = () => default;

    private readonly Option<string[]> _strArrNone = Option<string[]>.None;

    [Benchmark]
    public void StrArrNoneDefault() => _strArrNone.IfNoneUnsafe(default(string[]?));

    [Benchmark]
    public void StrArrNoneLambda() => _strArrNone.IfNoneUnsafe(() => null);

    [Benchmark]
    public void StrArrNoneLambdaStatic() => _strArrNone.IfNoneUnsafe(_nullStrArrFun);

    [Benchmark]
    public void StrArrNoneExtension() => _strArrNone.IfNoneNull();

    private readonly Option<string[]> _strArrSome = Option<string[]>.Some(["First", "Second"]);

    [Benchmark]
    public void StrArrSomeDefault() => _strArrSome.IfNoneUnsafe(default(string[]?));

    [Benchmark]
    public void StrArrSomeLambda() => _strArrSome.IfNoneUnsafe(() => null);

    [Benchmark]
    public void StrArrSomeLambdaStatic() => _strArrSome.IfNoneUnsafe(_nullStrArrFun);

    [Benchmark]
    public void StrArrSomeExtension() => _strArrSome.IfNoneNull();

    // C

    private static readonly Func<C?> _nullCFun = () => default;

    private readonly Option<C> _cNone = Option<C>.None;

    [Benchmark]
    public void CNoneDefault() => _cNone.IfNoneUnsafe(default(C?));

    [Benchmark]
    public void CNoneLambda() => _cNone.IfNoneUnsafe(() => null);

    [Benchmark]
    public void CNoneLambdaStatic() => _cNone.IfNoneUnsafe(_nullCFun);

    [Benchmark]
    public void CNoneExtension() => _cNone.IfNoneNull();

    private readonly Option<C> _cSome = Option<C>.Some(new C(22));

    [Benchmark]
    public void CSomeDefault() => _cSome.IfNoneUnsafe(default(C?));

    [Benchmark]
    public void CSomeLambda() => _cSome.IfNoneUnsafe(() => null);

    [Benchmark]
    public void CSomeLambdaStatic() => _cSome.IfNoneUnsafe(_nullCFun);

    [Benchmark]
    public void CSomeExtension() => _cSome.IfNoneNull();

    // C Array

    private static readonly Func<C[]?> _nullCArrFun = () => default;

    private readonly Option<C[]> _cArrNone = Option<C[]>.None;

    [Benchmark]
    public void CArrNoneDefault() => _cArrNone.IfNoneUnsafe(default(C[]?));

    [Benchmark]
    public void CArrNoneLambda() => _cArrNone.IfNoneUnsafe(() => null);

    [Benchmark]
    public void CArrNoneLambdaStatic() => _cArrNone.IfNoneUnsafe(_nullCArrFun);

    [Benchmark]
    public void CArrNoneExtension() => _cArrNone.IfNoneNull();

    private readonly Option<C[]> _cArrSome = Option<C[]>.Some([new C(22), new C(63)]);

    [Benchmark]
    public void CArrSomeDefault() => _cArrSome.IfNoneUnsafe(default(C[]?));

    [Benchmark]
    public void CArrSomeLambda() => _cArrSome.IfNoneUnsafe(() => null);

    [Benchmark]
    public void CArrSomeLambdaStatic() => _cArrSome.IfNoneUnsafe(_nullCArrFun);

    [Benchmark]
    public void CArrSomeExtension() => _cArrSome.IfNoneNull();

    private sealed class C
    {
        private readonly int _v;
        public C(int v) => this._v = v;
    }

}