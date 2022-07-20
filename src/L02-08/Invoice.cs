using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_08
{
    internal class Invoice
    {
        const double VAT = 19;
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;
        double price;
        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.price = price;
        }
        double CalculateOrderCostWithVAT()
        {
            return Math.Round((double)quantity * price * (1 + VAT / 100), 2);
        }
        double CalculateOrderWithoutVAT()
        {
            return Math.Round((double)quantity * price, 2);
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
            Console.WriteLine($"Sum without VAT: {CalculateOrderWithoutVAT()}");
            Console.WriteLine($"VAT:             {Math.Round(CalculateOrderCostWithVAT() - CalculateOrderWithoutVAT(), 2)}");
            Console.WriteLine($"Sum with VAT:    {CalculateOrderCostWithVAT()}");
        }
    }
}
