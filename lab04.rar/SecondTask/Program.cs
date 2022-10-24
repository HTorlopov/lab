namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage(new Sword(), new Axe(), new Bow());
            storage.ShowTree(); 
        }
    }
}