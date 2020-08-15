using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace NETFinal22
{

    public class Qn21
    {
        public static void Main()
        {
            GenericCollection<int> intArray = new GenericCollection<int>();
            intArray.Add(1);

            GenericCollection<string> stringArray = new GenericCollection<string>();
            stringArray.Add("Final Example");

        }
    }


    public class GenericCollection<T>
    {
        private T[] _items = new T[50];

        private int _numitems = 0;

        public void Add(T item)
        {
            if (_numitems + 1 < 50)
            {
                _items[_numitems] = item;
                _numitems++;
            }
        }
    }
}