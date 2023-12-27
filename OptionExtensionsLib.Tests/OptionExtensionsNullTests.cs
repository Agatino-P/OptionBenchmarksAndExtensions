using FluentAssertions;
using LanguageExt;

namespace OptionExtensionsLib.Tests;

public class OptionExtensionsNullTests
{

    //Struct

    [Fact]
    public void NullOnNone_Should_Return_Null_Given_None()
    {
        Option<int> optNone = Option<int>.None;
        int? actual = optNone.NullOnNone();
        actual.Should().BeNull();
    }

    [Fact]
    public void NullOnNone_Should_Return_Some_Given_Some()
    {
        const int intVal = 5;
        Option<int> optVal = intVal;
        int? actual = optVal.NullOnNone();
        actual.Should().Be(intVal);
    }

   
}

