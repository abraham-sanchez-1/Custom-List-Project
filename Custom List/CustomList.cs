 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        T[] list;
        int capacity;
        public CustomList()
        {
            capacity = 5;
            list = new T[capacity];
        }
        
        public void Add(T item)
        {
            //count formula to be devised down the road
            if (list.Count % 5 == 0)
            {
                capacity += 5;
            }
           
        
        }
        
    }
}
