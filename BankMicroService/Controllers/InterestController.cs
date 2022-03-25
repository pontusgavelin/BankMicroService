using System.Text.Json;
using BankMicroService.Models;

namespace BankMicroService.Controllers;

public class InterestController
{
    // Imaginary HTTP endpoint
    public InterestResponse getCurrentInterest(string interestQueryJson)
    {
        var interestQuery = JsonSerializer.Deserialize<InterestQuery>(interestQueryJson);

        if (!interestQuery.isValid())
        {
            return null;
        }
        
        return new InterestResponse();
    }
}