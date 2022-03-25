namespace BankMicroService.Models;

public class InterestBaseInformation
{
    public string AccountId { get; set; }
    public string AccountHolderName { get; set; }
    public Account Account { get; set; }
}

public class Account
{
    public decimal Balance { get; set; }
    public string Currency { get; set; }
}