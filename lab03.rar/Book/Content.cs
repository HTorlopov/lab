using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Content : BookAttribute
    {
        public Content(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
}
