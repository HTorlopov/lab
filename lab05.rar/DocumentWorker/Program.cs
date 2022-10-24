using System.Text;

namespace DocumentWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DocumentWorker documentWorker = null;

            Dictionary<string, string> keys = new Dictionary<string, string>()
            {
                {"exp", 11112222.ToString()}, {"pro", 22224444.ToString()}
            };

            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Enter license key - [exp/pro] XXXXXXXX");

                string[] msg = Console.ReadLine().Split(" ");

                if (msg.Length == 2)
                {
                    string value;
                    if (!keys.TryGetValue(msg[0], out value))
                    {
                        documentWorker = new DocumentWorker();
                        break;
                    }

                    if (msg[1] != value)
                        continue;

                    if (msg[0] == "exp")
                    {
                        documentWorker = new ExpertDocumentWorker();
                    }
                    else if (msg[0] == "pro")
                    {
                        documentWorker = new ProDocumentWorker();
                    }
                }
                else
                    documentWorker = new DocumentWorker();

                break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(documentWorker.Mode);
                Console.WriteLine("Current buffer: " + documentWorker.Doc);
                Console.WriteLine("open/edit/save");

                string[] msg = Console.ReadLine().Split(" ");

                if (msg[0] == "open")
                {
                    documentWorker.OpenDocument();
                }
                else if (msg[0] == "edit")
                {
                    documentWorker.EditDocument();
                }
                else if (msg[0] == "save")
                {
                    documentWorker.SaveDocument();
                }

                Console.ReadLine();
            }
        }
    }
}