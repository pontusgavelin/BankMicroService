using System.Text.Json;
using BankMicroService.Models;

namespace BankMicroService.Services;

public class InterestService : IInterestService
{
    private decimal interest = 0.1m;

    public InterestService()
    {
        
    }
    public decimal CalculateInterest(decimal balance)
    {
        return balance * interest;
    }
    
    
}