using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace openExchangeRates
{
    class Program
    {
        static void Main()
        {
            var url = "https://openexchangerates.org/api/latest.json?app_id=3ffce3987c764a84bdb8fad0aa0bd7c2";
            var currencyRates = _download_serialized_json_data<CurrencyRates>(url);
            decimal test;

            Console.WriteLine("CURRENCY CONVERTER: USD <==> CNY");
            if (currencyRates.rates.ContainsKey("CNY"))
            {
                if (currencyRates.rates.TryGetValue("CNY", out test))
                {
                    Console.WriteLine("1 USD = " + test.ToString("#0.0000") + " CNY");
                    Console.WriteLine("1 CNY = " + (1 / test).ToString("#0.0000") + " USD");
                }

            }

            Console.WriteLine("\r\nFROM: USD, TO: ?");
            string toCurrency = Console.ReadLine();
            string to = toCurrency.ToUpper();
            if (currencyRates.rates.ContainsKey(to))
            {
                if (currencyRates.rates.TryGetValue(to, out test))
                {
                    Console.WriteLine("1 USD = " + test.ToString("#0.0000") + to);
                    Console.WriteLine("1 " + to + " = " + (1 / test).ToString("#0.0000") + " USD");
                    Console.WriteLine("TO: " + to);
                }
            }
            else
            {
                Console.WriteLine("No such currency exist!");
            }

            Console.ReadKey();
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception e)
                {
                    throw e;
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}
