using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Excelent Read");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent Write");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent Relax");
        }

        public override void Study()
        {
            Console.WriteLine("Excelent Study");
        }
    }
}
