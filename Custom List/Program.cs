using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> listOfNumbers = new CustomList<int>();
            listOfNumbers.Add(4);
            listOfNumbers.Add(5);
            listOfNumbers.Add(6);
            listOfNumbers.Add(7);
            listOfNumbers.Remove(5);
            
            
           

        }
    }
}
