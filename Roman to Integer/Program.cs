using NUnit.Framework;

[TestFixture]
public class Solution2Tests
{
    [Test]
    public void RomanToInt_III_Returns3()
    {
        // Arrange
        Program solution = new Program();
        string input = "III";
        
        // Act
        int result = solution.RomanToInt(input);
        
        // Assert
        Assert.AreEqual(result, 3); // He
    }

    [Test]
    public void RomanToInt_LVIII_Returns58()
    {
        // Arrange
        Program solution = new Program();
        string input = "LVIII";
        
        // Act
        int result = solution.RomanToInt(input);
        
        // Assert
        Assert.AreEqual(58, result); // Correct assertion
    }

    [Test]
    public void RomanToInt_MCMXCIV_Returns1994()
    {
        // Arrange
        Program solution = new Program();
        string input = "MCMXCIV";
        
        // Act
        int result = solution.RomanToInt(input);
        
        // Assert
        Assert.AreEqual(1994, result); // Correct assertion
    }
}
