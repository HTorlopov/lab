using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public abstract class AttributeManager
    {
        public virtual void Show(params object[] values)
        {     
            foreach (object type in values)
            {
                Debug.Print($"{type.GetType()} - {type}");
            }
        }         
    }
}
