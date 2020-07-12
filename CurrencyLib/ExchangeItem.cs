using System;

public class ExchangeItem {
    public string CurrencyCode { get; set; }
    public int Unit { get; set; }
    public string CurrencyNameTR { get; set; }
    public string CurrencyName { get; set; }
    public Decimal ForexBuying { get; set; }
    public Decimal ForexSelling { get; set; }
    public Decimal BanknoteBuying { get; set; }
    public Decimal BanknoteSelling { get; set; }
    public Decimal CrossRateUSD { get; set; }
    public Decimal CrossRateOther { get; set; }
}
