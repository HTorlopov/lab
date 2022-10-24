using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public abstract class BookAttribute
    {
        private string _content;
        private ConsoleColor _color;

        public BookAttribute(string content, ConsoleColor color)
        {
            _content = content;
            _color = color;
        }

        public virtual void Show()
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(_content);
            Console.ForegroundColor = ConsoleColor.White;
        }     
    }
}
