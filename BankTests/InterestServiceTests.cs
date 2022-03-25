using BankMicroService.Services;
using NUnit.Framework;

namespace BankTests;

public class InterestServiceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Should_Return_100_When_Calculating_Interest_For_Balance_Of_1000()
    {
        // Arrange
        var interestService = new InterestService();
        var balance = 1000m;
        var expected = 100m;
        
        // Act
        var actual = interestService.CalculateInterest(balance);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Should_Return_0_When_Calculating_Interest_For_Balance_Of_0()
    {
        // Arrange
        var interestService = new InterestService();
        var balance = 0m;
        var expected = 0m;
        
        // Act
        var actual = interestService.CalculateInterest(balance);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }

}