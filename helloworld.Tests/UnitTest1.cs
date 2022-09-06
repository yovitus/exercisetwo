namespace helloworld.test;
using helloworld;
public class UnitTest1
{
    [Fact]
    public void test1()
    {
        //Arange
        
    
        //Act
        var result = Program.isYearLeapYear(1600);
        var resultTwo = Program.isYearLeapYear(1601);

        //Assert
        result.Should().Be(true);
        resultTwo.Should().Be(false);
    }

    [Fact]
    public void test2()
    {
        int isYearLeapYear1 = 1500;
        int isYearLeapYear2 = 1600;
        
        Action action1 = () => Program.lessThan(isYearLeapYear1);
        Action action2 = () => Program.lessThan(isYearLeapYear2);

        action1.Should().Throw<Program.lessThanException>("Year too low");
        action2.Should().NotThrow<Program.lessThanException>("Year is above 1587");

    }

    [Fact]
    public void test3()
    {
        String input = "Hello";

        Action action1 = () => Program.isYearLeapYear(Int32.Parse(input));

        action1.Should().Throw<System.FormatException>("Input is not and int");
    }
}