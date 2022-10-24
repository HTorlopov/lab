using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Author : BookAttribute
    {
        public Author(string content) : base(content, ConsoleColor.Green)
        {
        }

        public Author(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
}
