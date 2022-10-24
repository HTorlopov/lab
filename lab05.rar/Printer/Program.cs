namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter printer = new ColorPrinter();
            printer.Print("One");
            printer.Print("Two");
        }
    }
}