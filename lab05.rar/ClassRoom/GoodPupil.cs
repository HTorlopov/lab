using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Good Read");
        }

        public override void Write()
        {
            Console.WriteLine("Good Write");
        }

        public override void Relax()
        {
            Console.WriteLine("Good Relax");
        }

        public override void Study()
        {
            Console.WriteLine("Good Study");
        }
    }
}
