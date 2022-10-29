using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal interface IMyList<T>
    {
        public int Count { get; }
        public int Capacity { get; set; }
        public T this[int index] { get; }
        public void Add(T item);
    }
}
