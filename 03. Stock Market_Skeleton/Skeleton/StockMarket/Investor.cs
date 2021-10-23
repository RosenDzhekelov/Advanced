using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;
        public string FullName { get; set; }
        public string EmailAdress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public int Count => portfolio.Count;
        public string BrokerName { get; set; }
        public Investor(string fullName,string emailAdress , decimal moneyToInvest , string brokerName)
        {
            FullName = fullName;
            EmailAdress = emailAdress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }
        
        public void BuyStock(Stock stock)
        {
            if(stock.MarketCapitalization>10000 && MoneyToInvest>=stock.PricePerShare)
            {
                MoneyToInvest -= stock.PricePerShare;
                portfolio.Add(stock);
            }
        }
        public string SellStock(string companyName , decimal sellPrice)
        {
            Stock stock = portfolio.FirstOrDefault(s => s.CompanyName == companyName);
            if(stock== null)
            {
                return $"{companyName} does not exist.";
            }
            if(sellPrice<stock.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            portfolio.Remove(stock);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
            => portfolio.FirstOrDefault(s => s.CompanyName == companyName);

        public Stock FindBiggestCompany()
            => portfolio.OrderByDescending(s => s.MarketCapitalization).FirstOrDefault();

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
