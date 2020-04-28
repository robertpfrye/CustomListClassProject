using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int count;
        private int capacity;


        // constructor (SPAWNER)

        public CustomList()
        {
            count = 0;
            items = new T[4];
            items = new T[capacity];
        }


        // member methods (CAN DO)

        //Indexer
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        //add
        public void Add(T item)
        {
            items[count] = item;
            count++;
        }

        //remove
        public void Remove(T item)
        {
            items[count] = item;
            count--;
        }
    }
}
