using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_08
{
    internal class Invoice
    {
        private const double VAT = 19;
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;
        private double price;
        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.price = price;
        }
        private double GetOrderCostWithVAT(bool withVAT)
        {
            double cost = Math.Round((double)quantity * price, 2);
            if (withVAT)
            {
                return Math.Round(cost * (1 + VAT / 100), 2);
            }
            else
            {
                return cost;
            }
        }
        public void Show()
        {
            Console.WriteLine("Invoice.");
            Console.WriteLine($"Account:  {account}");
            Console.WriteLine($"Customer: {customer}");
            Console.WriteLine($"Provider: {provider}");
            Console.WriteLine($"Article:  {article}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price:    {price}");

            // Why "private double test;" is wrong?
            double orderCostWithoutVAT = GetOrderCostWithVAT(false);
            double orderCostWithVAT = GetOrderCostWithVAT(true);

            Console.WriteLine($"Sum without VAT: {orderCostWithoutVAT}");
            Console.WriteLine($"VAT:             {Math.Round(orderCostWithVAT - orderCostWithoutVAT,2)}");
            Console.WriteLine($"Sum with VAT:    {orderCostWithVAT}");
        }
    }
}
