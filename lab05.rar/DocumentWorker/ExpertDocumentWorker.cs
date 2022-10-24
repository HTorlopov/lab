using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override string Mode { get { return "Expert version"; } }
        public ExpertDocumentWorker()
        {
            string? path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtnew";
            File.Create(filePath).Dispose();
        }

        public override void SaveDocument()
        {
            File.WriteAllText(filePath, doc);
            Console.WriteLine("Документ збережений в новому форматі");
            doc = "";
        }
    }
}
