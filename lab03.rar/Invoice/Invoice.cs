using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;
  
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public void Calculate(float price, bool VAT = false)
        {
            Console.WriteLine($"Account {account}");
            Console.WriteLine($"Customer {customer}");
            Console.WriteLine($"Provider {provider}");
            Console.WriteLine($"Provider {article}");
            Console.WriteLine($"Provider {quantity}");
            Console.WriteLine($"Price {price}");

            if (VAT)
            Console.WriteLine($"Price with VAT {price + price * 0.07f}");
        }
    }
}
