namespace BankMicroService.Models;

public class InterestQuery : InterestBaseInformation
{
    public DateTime LatestTransactionTime { get; set; }

    public bool isValid()
    {
        return Guid.TryParse(AccountId, out _) &&
               string.IsNullOrWhiteSpace(AccountHolderName) &&
               Account?.Balance >= 0 &&
               string.IsNullOrWhiteSpace(Account?.Currency) &&
               LatestTransactionTime < DateTime.Now;
    }
}