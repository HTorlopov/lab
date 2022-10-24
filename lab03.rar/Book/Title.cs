using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Title : BookAttribute
    {
        public Title(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
}
