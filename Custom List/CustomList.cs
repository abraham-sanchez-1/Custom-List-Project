﻿ using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T> : IEnumerable where T: IComparable
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
                if (i>=count || i<0)
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
                if (i >= count || i < 0)
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
        //Single responsibility usage, remove method 
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
            CustomList<T> placeHolder = new CustomList<T>();
            for (int i = 0; i < indexToBeRemoved; i++)
            {
                placeHolder.Add(array[i]);
            }
            for (int i = indexToBeRemoved; i < count-1; i++)
            {
                
                placeHolder.Add(array[i+1]);
            }
            for (int i = 0; i < placeHolder.count; i++)
            {
                array[i + 1] = default;
                array[i] = placeHolder[i];
            }
            
        }
        //Sort method addition
        public void Sort() 
        {
            int i, j;
            int N = count;
            for (j= count- 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    int comparer = 0;
                    comparer = array[i].CompareTo(array[i + 1]);
                    if (comparer <=0)
                    {
                        Exchange(array, i, i + 1);
                    }
                }

            }
        }
        public static void Exchange(T[] list, int m, int n)
        {
            T placeholder;

            placeholder = list[m];
            list[m] = list[n];
            list[n] = placeholder;

        }
        public override string ToString()
        {       
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newString.Append(array[i]);
            }
            return newString.ToString();
        }
        public void Zip(CustomList<T> list)
        {
            CustomList<T> placeholder = new CustomList<T>();
            for (int i = 0; i < (count > list.Count ?  count : list.Count); i++)
            {
                if(i < count)
                    placeholder.Add(array[i]);

                if(i < list.Count)
                    placeholder.Add(list[i]); 

            }

            array = placeholder.ToArray();
            count = placeholder.Count;

        }
        public T[] ToArray()
        {
            return array;
        }
        public static CustomList<T>  operator+(CustomList<T> listOne, CustomList<T> listTwo) 
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                newList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count ; i++)
            {
                newList.Add(listTwo[i]);
            }

            return newList;

        }
        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    listOne.Remove( listTwo[j] );
                }
            }
            return listOne;

        }
        //iterator
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < array.Count(); index++)
            {
                yield return array[index];
            }
        }


    }
}
