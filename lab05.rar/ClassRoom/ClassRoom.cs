using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ClassRoom
    {
        List<Pupil> pupils;

        public ClassRoom(params Pupil[] values)
        {
            if (values.Length < 2 || values.Length > 4)
                return;


            pupils = values.ToList();
        }

        public void ShowPupils()
        {
            foreach (Pupil pupil in pupils)
            { 
                pupil.Print();
            }
        }
    }
}
