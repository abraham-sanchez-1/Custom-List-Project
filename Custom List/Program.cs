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
            CustomList<int> listOfNumbers = new CustomList<int>() { 4,5,6,7,5,20,5,20};
            listOfNumbers.Remove(5);


            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

            CustomList<int> secondList = new CustomList<int> { 5, 20 };
            CustomList<int> newlist = new CustomList<int>();
            newlist = listOfNumbers - secondList;

            Console.WriteLine("\nData Split\n");



            foreach (var number in newlist)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();


        }
    }
}
