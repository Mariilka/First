using NUnit.Framework;
using First;
namespace TestProject1;

public class Tests
{

    
    public void Test1()
    {
        
        int number = 100;

        bool result = Logic.IsThreeDigitNumber(number);

        Assert.True(result);
    }
    public void Test2()
    {
        // Arrange
        int number = 500;

        // Act
        bool result = Logic.IsThreeDigitNumber(number);

        // Assert
        Assert.True(result);
    }
}