using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T>
    {
        private List<T> list;

        public GenericList()
        {
            list = new List<T>();
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public void PrintList()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
