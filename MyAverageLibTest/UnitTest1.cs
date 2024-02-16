using Xunit;
using MyAverageLib;
namespace MyAverageLibTest;

public class UnitTest1
{
    [Fact]
    public void TestAverageOf2()
    {
        double a = 13;//arrange
        double b = 24;//arrange
        double expected = 18.5;

        double actual = Average.MyAverage(a,b); //act

        Assert.Equal(expected, actual); //assert
    }
    [Fact]
    public void TestAverageOf3()
    {
        double a = 13; //arrange
        double b = 24; //arrange
        double c = 26; //arrange
        double expected = 21;

        double actual = Average.MyAverage(a,b,c); //act

        Assert.Equal(expected, actual); //assert
    }
}