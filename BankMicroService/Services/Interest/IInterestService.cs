namespace BankMicroService.Services;

public interface IInterestService
{
    public decimal CalculateInterest(decimal balance);
    
}