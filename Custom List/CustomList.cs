 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        //creation of array
        private T[] array;
        //creation of indexer
        public T this[int i]
        {
            get
            {
                if (i>count || i<0)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                else
                {
                    return array[i];
                }
            }
            set
            {

                if (i > count || i < 0)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                else
                {
                    array[i] = value;
                }
            }
        }
           
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
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
                capacity *= 2;
                T[] placeholder = array;
                array = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    array[i] = placeholder[i];
                }
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    Concatenate(i);
                    count -= 1;
                    return true;
                }
                
            }
            return false;
        }
        public void Concatenate(int indexToBeRemoved)
        {
            T[] firstPlaceholder = new T[capacity];
            for (int j = 0; j < indexToBeRemoved; j++)
            {
                firstPlaceholder[j] = array[j];
            }
            int upperLimit = Count - 1;
            for (int i = indexToBeRemoved; i < upperLimit; i++)
            {
                firstPlaceholder[i] = array[i+1];
            }
            for (int i = 0; i < count; i++)
            {
                array[i] = firstPlaceholder[i];
            }

        }
        //C# indexer


    }
}
