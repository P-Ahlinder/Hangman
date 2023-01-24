using Hangman.Components;
namespace HangmanTest;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int result = 0;

        result = 2 + 2;
        Assert.Equal(4, result);
        Console.WriteLine(result);
    }

    [Fact]
    public void Test2()
    {
        int result = 0;

        result = 4;
        Assert.Equal(4, result);
        Console.WriteLine(result);
    }

}