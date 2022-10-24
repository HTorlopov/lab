using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal abstract class Pupil
    {
        public virtual void Study()
        {

        }       
        
        public virtual void Read()
        {

        }        
        
        public virtual void Write()
        {

        }       
        
        public virtual void Relax()
        {

        }

        public void Print()
        {
            Study();
            Read();
            Write();
            Relax();
            Console.WriteLine();
        }
    }
}
