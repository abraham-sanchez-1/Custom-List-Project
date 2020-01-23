 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        public int count;
        public int Count
        {
            get
            {
                return count;
            }
            //is set not required
            //set
            //{
            //    count = value;
            //}
        }
        public T[] array;
        public int capacity;
        public int Capacity;
        public CustomList()
        {
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }
        
        public void Add(T item)
        {
            array[count] = item;
            count++;
            if (count == capacity)
            {
                IncreaseCapacity();
            }
        }
        public void IncreaseCapacity()
        {
                capacity += 5;
                T[] placeholder = array;
                array = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    array[i] = placeholder[i];
                }
        }
        
        
    }
}
