using FluentAssertions;
using LanguageExt;

namespace OptionExtensionsLib.Tests;

public class OptionExtensionsNullableTests
{
    //Struct Array

    [Fact]
    public void IfNoneNull_Should_Return_Null_Given_StructArray_None()
    {
        Option<int[]> optNone = Option<int[]>.None;
        int[]? actual = optNone.IfNoneNull();
        actual.Should().BeNull();
    }

    [Fact]
    public void IfNoneNull_Should_Return_Some_Given_StructArray_Some()
    {
        int[] intArr = [1, 2];
        Option<int[]> optArr = Option<int[]>.Some(intArr);
        int[]? actual = optArr.IfNoneNull();
        actual.Should().BeEquivalentTo(intArr);
    }

    // Class

    [Fact]
    public void IfNoneNull_Should_Return_Null_Given_None()
    {
        Option<C> optCNone = Option<C>.None;
        C? actual = optCNone.IfNoneNull();
        actual.Should().BeNull();
    }

    [Fact]
    public void IfNoneNull_Should_Return_Some_Given_Some()
    {
        C c = new(99);
        Option<C> optCNone = Option<C>.Some(c);
        C? actual = optCNone.IfNoneNull();
        actual.Should().Be(c);
    }

    // class Array
    [Fact]
    public void IfNoneNull_Should_Return_Null_Given_None_of_array()
    {
        Option<C[]> optCNone = Option<C[]>.None;
        C[]? actual = optCNone.IfNoneNull();
        actual.Should().BeNull();
    }

    [Fact]
    public void IfNoneNull_Should_Return_Some_Given_SomeArray()
    {
        C[] cArray = [new C(1), new C(4)];
        Option<C[]> optCSome = cArray;
        C[]? actual = optCSome.IfNoneNull();
        actual.Should().BeEquivalentTo(cArray);
    }
    private class C
    {
        private readonly int _c;

        public C(int c)
        {
            this._c = c;
        }
    }

}
