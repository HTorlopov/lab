namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteAttManager concreteAttManager = new ConcreteAttManager();
            concreteAttManager.Show(15, "name", DateTime.Now);
        }
    }
}