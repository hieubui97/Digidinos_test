using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai24_Queue<T>
    {
        private static List<T> queue = new List<T>();

        public T get()
        {
            var result = queue.FirstOrDefault();
            queue.Remove(result);

            return result;
        }

        public void push(T obj)
        {
            queue.Add(obj);
        }
    }
}
