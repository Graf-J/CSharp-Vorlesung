using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAufgabe
{
    internal class Array<T>
    {
        private T[] array;
        
        public Array(int length)
        {
            array = new T[length];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public string GetTypeInfo()
        {
            return typeof(T).ToString();
        }
    }
}
