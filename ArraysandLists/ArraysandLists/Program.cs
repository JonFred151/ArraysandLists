using System;
namespace ArraysandLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish the array and lists
           var myNums = new int[10]  {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var odds = new List<int>();
            var even = new List<int>();


            //sort the array numbers into evens or odds 
            for (int i = 0; i < myNums.Length; i++)
            {
                if (myNums[i] % 2 == 0)
                {
                    even.Add(myNums[i]);

                }
                else
                {
                    odds.Add(myNums[i]);
                }
               
               
            }

            // writes out the odds number in the list 
             foreach (var i in odds)
                { 
                   Console.WriteLine( $"{i} is an odd number");
                }

             // write out the even numbers in the list 
             foreach(var i in even)
            {
                Console.WriteLine($"{i} is an even number");
            }






        }
    }
}