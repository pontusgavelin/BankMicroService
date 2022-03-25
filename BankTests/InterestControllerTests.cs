using System;
using System.Text.Json;
using BankMicroService.Controllers;
using BankMicroService.Utils;
using NUnit.Framework;

namespace BankTests;

public class InterestControllerTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void Should_Throw_JsonException_When_Invalid_Json()
    {
        var interestController = new InterestController();
        var faultyJson = JsonUtils.GetFaultyJsonData();
        
        Assert.Throws<Exception>(() => interestController.getCurrentInterest(faultyJson));
    }
}