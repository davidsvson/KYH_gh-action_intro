using Xunit;


public class CalculatorTest 
{

    [Fact]
    public void TestAdd() 
    {
         // given 
        Calculator calc = new();

        int a = 5;
        int b = 2;
        int expectedResult = 7;

         // when
        int result = calc.Add(a, b);

         // then
        Assert.Equal(expectedResult, result );


    }


    [Fact]
    public void TestSubtract() 
    {
         Calculator calc = new();

        int a = 5;
        int b = 2;
        int expectedResult = 3;

         // when
        int result = calc.Subtract(a, b);

         // then
        Assert.Equal(expectedResult, result );
    }





}