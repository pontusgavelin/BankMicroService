using LoggerService.Logger;
using NUnit.Framework;

namespace LoggerTests;

public class Tests
{
    [Test]
    public void Logger_Should_Be_Called()
    {
        var logger = new Logger();

        logger.log("Test Message");
        Assert.True(true);
    }

    [Test]
    public void Logger_Result_Message_Should_Be_200_Characters_When_Message_In_Is_300_Characters_Long()
    {
        var logger = new Logger();

        var superLongMessage = "";
        for (var i = 0; i < 300; i++)
        {
            superLongMessage += i.ToString();
        }
        
        logger.log(superLongMessage);
        Assert.AreEqual(200, logger.resultingLogmessage.Length);
    }
}