using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExamples.Structures
{
    public class CircularBuffer2<T>
    {
        private readonly T[] buffer = new T[2];
        private int index = 0;

        public void Add(T item)
        {
            buffer[index] = item;
            index = (index + 1) % 2;
        }

        public T this[int i] => buffer[i];

        public IEnumerable<T> GetItems()
        {
            yield return buffer[0];
            yield return buffer[1];
        }
    }

}
