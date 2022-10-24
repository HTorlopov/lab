namespace Invoice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(0, "Customer_name", "provider_name", "article_name", 1);
            invoice.Calculate(1700, true);
        }
    }
}