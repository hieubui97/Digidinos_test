using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai25_Stack<T>
    {
        private static List<T> stack = new List<T>();

        public T get()
        {
            var result = stack.LastOrDefault();
            stack.Remove(result);

            return result;
        }

        public void push(T obj)
        {
            stack.Add(obj);
        }
    }
}
