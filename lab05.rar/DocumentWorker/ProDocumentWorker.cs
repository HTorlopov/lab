using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override string Mode { get { return "Pro version"; } }
        public override void EditDocument()
        {
            Console.WriteLine("Rewrite document:");
            doc = Console.ReadLine();
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            File.WriteAllText(filePath, doc);
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
            doc = "";
        }
    }
}
