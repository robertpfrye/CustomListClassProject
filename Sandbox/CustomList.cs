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
        private int capacity = 4;


        // constructor (SPAWNER)

        public CustomList()
        {
            count = 0;
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
            if(count == capacity)
            {
                //1. double capacity
                capacity *= 2;

                //2. make tempArray to store values temporarily
                T[] tempArray = new T[capacity];

                //3. copy over values from items to tempArray
                //for loop
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = items[i];
                }
 

                //4. insert item in next available index of tempArray
                tempArray[count] = item;

                //5. increase count
                count++;

                //6. items looks like tempArray 
                items = tempArray;
            }
            else
            {
                items[count] = item;
                count++;
            }
            
        }

        //remove
        
        public void Remove(T item)//select item to be romoved
        {
            //2 4 6 8 10
            //Remove(4)
            //2 6 8 10

            //find item in items -- for loop & if statement .Equals()
            //shift values down each index i.e. items[i] = ?
            //decrement count

            //IF I GET STUCK, I AM SENDING THE INSTRUCTORS A QUESTION WITH A SCREENSHOT

            items[count] = item;
            count--;
        }
    }
}
