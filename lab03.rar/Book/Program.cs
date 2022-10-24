namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Author("Some author", ConsoleColor.Red), new Title("Some title", ConsoleColor.Blue), new Content("Some content", ConsoleColor.Yellow));
            book.Show();
            Console.ReadLine();
        }
    }
}