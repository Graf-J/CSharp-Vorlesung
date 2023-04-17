using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAufgabe
{
    internal class Liste<T>
    {
        private List<T> list = new List<T>();

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public string GetTypeInfo()
        {
            return typeof(T).ToString();
        }
    }
}
