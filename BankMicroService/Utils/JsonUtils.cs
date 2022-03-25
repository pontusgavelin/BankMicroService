using System.Data.Common;

namespace BankMicroService.Utils;

public static class JsonUtils
{
    public static string GetCorrectJsonData() =>
        "{\"AccountId\":\"1337\",\"AccountHolderName\":\"HeatoN\",\"Account\":{\"Balance\":\"100000000\",\"Currency\":\"BTC\"},\"LatestTransactionTime\":\"2015-05-16T05:50:06\"}";

    public static string GetFaultyJsonData() =>
        "{\"NotAccountId\":\"1337\",\"SomeWeirdProperty\":\"HeatoN\",\"Stuff\":{\"Balance\":\"100000000\",\"Currency\":\"BTC\"},\"LatestTransactionTime\":\"2025-05-16T05:50:06\"}";
}