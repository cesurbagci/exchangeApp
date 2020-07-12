using System;

public class CurrencyCode
{
    private CurrencyCode(string value) { Value = value; }

    public string Value { get; set; }

    public static CurrencyCode USD   { get { return new CurrencyCode("USD"); } }
    public static CurrencyCode AUD   { get { return new CurrencyCode("AUD"); } }
    public static CurrencyCode DKK   { get { return new CurrencyCode("DKK"); } }
    public static CurrencyCode EUR   { get { return new CurrencyCode("EUR"); } }
    public static CurrencyCode GBP   { get { return new CurrencyCode("GBP"); } }
    public static CurrencyCode CHF   { get { return new CurrencyCode("CHF"); } }
    public static CurrencyCode SEK   { get { return new CurrencyCode("SEK"); } }
    public static CurrencyCode CAD   { get { return new CurrencyCode("CAD"); } }
    public static CurrencyCode KWD   { get { return new CurrencyCode("KWD"); } }
    public static CurrencyCode NOK   { get { return new CurrencyCode("NOK"); } }
    public static CurrencyCode SAR   { get { return new CurrencyCode("SAR"); } }
    public static CurrencyCode JPY   { get { return new CurrencyCode("JPY"); } }
    public static CurrencyCode BGN   { get { return new CurrencyCode("BGN"); } }
    public static CurrencyCode RON   { get { return new CurrencyCode("RON"); } }
    public static CurrencyCode RUB   { get { return new CurrencyCode("RUB"); } }
    public static CurrencyCode IRR   { get { return new CurrencyCode("IRR"); } }
    public static CurrencyCode CNY   { get { return new CurrencyCode("CNY"); } }
    public static CurrencyCode PKR   { get { return new CurrencyCode("PKR"); } }
    public static CurrencyCode QAR   { get { return new CurrencyCode("QAR"); } }
    public static CurrencyCode XDR   { get { return new CurrencyCode("XDR"); } }

}