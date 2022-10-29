using System.Diagnostics.Contracts;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);

            foreach (int item in list.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyClass<List<int>>.FactoryMethod());
        }
    }
}