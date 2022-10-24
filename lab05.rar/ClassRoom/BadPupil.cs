using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad Read");
        }

        public override void Write()
        {
            Console.WriteLine("Bad Write");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad Relax");
        }

        public override void Study()
        {
            Console.WriteLine("Bad Study");
        }
    }
}
