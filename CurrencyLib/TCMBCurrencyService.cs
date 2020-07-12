using System;
using System.Collections.Generic;
using System.Xml;

public interface IExchangeService {
    List<ExchangeItem> GetCurrencies(CurrencyCode currencyCode = null);
}

public class TCMBExchangeService: IExchangeService {

    private const string apiUrl = "http://www.tcmb.gov.tr/kurlar/today.xml";

    private XmlDocument xmlDoc { get; set; }

    public TCMBExchangeService()
    {
        loadExchangeRate();
    }    

    private void loadExchangeRate()
    {
        try {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(apiUrl);    

        } 
        catch (Exception ex) {
            throw new Exception("Not Found Currency Informations.");
        }

        if (xmlDoc == null)
        {
            throw new Exception("Not Found Currency Informations.");
        }
    }

    public List<ExchangeItem> GetCurrencies(CurrencyCode currencyCode = null) {
        List<ExchangeItem> result = new List<ExchangeItem>();
        
        if (currencyCode == null) {
            foreach (XmlElement nodeItem in xmlDoc.SelectSingleNode("Tarih_Date").ChildNodes)
            {
                result.Add(parseCurrencyDetail(nodeItem));
            }
        } else {
            XmlElement nodeItem = (XmlElement)xmlDoc.SelectSingleNode("Tarih_Date/Currency[@CurrencyCode='"+ currencyCode.Value +"']");
            result.Add(parseCurrencyDetail(nodeItem));
        }

        return result;
    }

    private ExchangeItem parseCurrencyDetail(XmlElement currencyNode) {
        ExchangeItem result = new ExchangeItem();
        System.Globalization.CultureInfo culInfo = new System.Globalization.CultureInfo("en-US", true);

        result.CurrencyCode = currencyNode.Attributes["Kod"].InnerText;

        foreach (XmlElement nodeItem in currencyNode.ChildNodes) 
        {
            switch (nodeItem.Name)
            {
                case "Unit":
                    result.Unit = Int32.Parse(nodeItem.InnerText);
                    break;
                case "Isim":
                    result.CurrencyNameTR = nodeItem.InnerText;
                    break;
                case "CurrencyName":
                    result.CurrencyName = nodeItem.InnerText;
                    break;
                case "ForexBuying":
                    result.ForexBuying = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
                case "ForexSelling":
                    result.ForexSelling = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
                case "BanknoteBuying":
                    result.BanknoteBuying = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
                case "BanknoteSelling":
                    result.BanknoteSelling = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
                case "CrossRateUSD":
                    result.CrossRateUSD = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
                case "CrossRateOther":
                    result.CrossRateOther = string.IsNullOrWhiteSpace(nodeItem.InnerText) ? 0 : Decimal.Parse(nodeItem.InnerText, culInfo);
                    break;
            }
        }

        return result;
    }
}