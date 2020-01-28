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
            List<int> nums = new List<int>() { 1, 2, 3 };
            int[] numArray = nums.ToArray();
            //instantiation of new custom list of type int
            CustomList<int> firstList = new CustomList<int>() { 4,5,6,7,5,20,5,20};

            foreach (var number in firstList)
            {
                Console.WriteLine(number);
            }
            //output - 4,5,6,7,5,20,5,20

            CustomList<int> secondList = new CustomList<int> { 5, 20 };
            CustomList<int> newList = new CustomList<int>();
            //Values of second list will be subtracted from first list
            newList = firstList - secondList;

            foreach (var number in newList)
            {
                Console.WriteLine(number);
            }
            //Return output - 4,6,7


            CustomList<string> stringlistone = new CustomList<string>() { "s", "t", "r"};
            CustomList<string> stringlisttwo = new CustomList<string>() { "i","n","g"};
            CustomList<string> newStringList = new CustomList<string>();
            CustomList<string> secondNewStringList = new CustomList<string>();
            
            newStringList = stringlistone + stringlisttwo;
            Console.WriteLine("\nData Split\n");



            foreach (var number in newList)
            {
                Console.WriteLine(number);
            }
            foreach (var letter in newStringList)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("\nData Split\n");
            CustomList<string> stringlistthree = new CustomList<string>() { "i","t" };
            secondNewStringList = newStringList - stringlistthree;
            foreach (var letters in secondNewStringList)
            {
                Console.WriteLine(letters);
            }
            Console.ReadLine();


        }
    }
}
