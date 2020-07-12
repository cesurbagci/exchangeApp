using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonExporterExtension;
using XmlConvertorExtension;

namespace CurrencyLib.testing
{
    public class Exchangeservice_IsExchangeShould
    {

        private IExchangeService _exchangeService;
        public Exchangeservice_IsExchangeShould()
        {
            _exchangeService = new TCMBExchangeService();
        }

        // you can pass inlinedata but not work static object
        [Fact]
        public void GetCurrencies_AllData()
        {
            var result = _exchangeService.GetCurrencies();
            
            Assert.True(result.Count > 0, "Not Found Currencies");
        }

        [Fact]
        public void GetCurrencies_ForUSD()
        {
            var result = _exchangeService.GetCurrencies(CurrencyCode.USD);
            
            Assert.True(result.Count == 1, "Not Found USD Currencies");
        }

        [Fact]
        public void GetCurrencies_ForEUR()
        {
            var result = _exchangeService.GetCurrencies(CurrencyCode.EUR);
            
            Assert.True(result.Count == 1, "Not Found EUR Currencies");
        }

        [Fact]
        public void ExportCurrenciesAsJson()
        {
            var result = _exchangeService.GetCurrencies(CurrencyCode.EUR).ConvertToJson();

            Assert.True(result.StartsWith("[{\"CurrencyCode\":"), "Not Converted as Json");
        }

        [Fact]
        public void ExportCurrenciesAsXml()
        {
            var result = _exchangeService.GetCurrencies(CurrencyCode.EUR).ConvertToXml();
            
            Assert.True(result.Contains("<ExchangeItem><CurrencyCode>EUR</CurrencyCode>"), "Not Converted as Xml");
        }
    }
}
