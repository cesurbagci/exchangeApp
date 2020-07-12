using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CurrencyTestApp;
using JsonExporterExtension;
using XmlConvertorExtension;

namespace CurrencyTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TCMBExchangeService service = new TCMBExchangeService();
            var result = service.GetCurrencies(CurrencyCode.USD);
           
            foreach (ExchangeItem item in result)
            {
                Console.WriteLine(item.CurrencyCode);
            }

            var json = result.ConvertToJson();
            Console.WriteLine(json);

            var xmlText = result.ConvertToXml();
            Console.WriteLine(xmlText);

            Console.ReadLine();
        }
    }
}
