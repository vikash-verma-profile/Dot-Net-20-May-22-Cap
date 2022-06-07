using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class ExchangeRate
    {
        // code here ...
        public string SourceCurrency;
        public string DestinationCurrency;
        public decimal Rate;
        public bool Error;


    }
    class Validation
    {
        // code here ...
        public IList<ExchangeRate> ValidateExchangeRate(IList<ExchangeRate> exchangeRate, IList<string> acceptedCurrencies)
        {
            IList<ExchangeRate> a1 = new List<ExchangeRate>();
            foreach (var erList in exchangeRate)
            {
                if (string.IsNullOrEmpty(erList.SourceCurrency)|| string.IsNullOrEmpty(erList.DestinationCurrency))
                {
                    erList.Error = true;
                    a1.Add(erList); 
                }
                if (erList.Rate < 0)
                {
                    erList.Error = true;
                    a1.Add(erList);
                }
                if (!acceptedCurrencies.Contains(erList.SourceCurrency) || !acceptedCurrencies.Contains(erList.DestinationCurrency))
                {
                    erList.Error = true;
                    a1.Add(erList);
                }
                if ((erList.SourceCurrency.Equals(erList.DestinationCurrency)) && erList.Rate != 1)
                {
                    erList.Error = true;
                    a1.Add(erList);
                }
            }
            return a1;
        }

    }

    class Source
    {
        static void Main(string[] args)
        {
            // code here ...
            var acceptedCurrencies = new List<string>
              {
                "INR",
                "EUR",
                "USD",
                "AED",
                "AUD"
              };
            var exchangeRates = new List<ExchangeRate>
      {
        new ExchangeRate{SourceCurrency = "", DestinationCurrency = "", Rate = 1},
        new ExchangeRate{SourceCurrency = "AED", DestinationCurrency = "AED", Rate = 1},
        new ExchangeRate{SourceCurrency = "AED", DestinationCurrency = "AUD", Rate = 1},
        new ExchangeRate{SourceCurrency = "GBP", DestinationCurrency = "GBP", Rate = 1},
      };
            var validation = new Validation();
            var errorList = validation.ValidateExchangeRate(exchangeRates, acceptedCurrencies);
            foreach (var item in errorList)
            {
                Console.WriteLine($"Source : {item.SourceCurrency}, Destination : {item.DestinationCurrency}, Rate : {item.Rate}, Error : {item.Error}");
            }
        }
    }
}