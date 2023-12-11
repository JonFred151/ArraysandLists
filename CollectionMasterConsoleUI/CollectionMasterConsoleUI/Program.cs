using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;



namespace CollectionMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays                      
            var number = new int[50];                                                                                                                                           // variable init and vaule assgin             
            Populater(number);                                                                                                                                                   //populate the number into the array
                                                                                                                                                                                 
            Console.WriteLine($" The first number in the array:{number[0]}");                                                                          // prints the first and last number
            Console.WriteLine($"The last number in the array:{number[49]}");            
            Console.WriteLine("--All Number Original--");                                                                                                       //prints the whole array
            NumberPrinter(number); 
            

            
            Console.WriteLine("---------REVERSE CUSTOM------------");                                                                           // reversed the array number
            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(number);
            Console.WriteLine("-------------------");

            //remove and set all numbers to three to zero
            Console.WriteLine("---------NO MULTIPLE OF THREE------------");                        
            Console.WriteLine("Multiple of three = 0: ");  
            ThreeKiller(number);               
            Console.WriteLine("-------------------");

            //sorts the numbers in order     
            SortArray(number);
            Console.WriteLine("Sorted numbers:");
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region List
            Console.WriteLine("***************Start List*****************");
            //Setting up
            int listSize = 50;
            var numList = new List<int>(listSize);
            Populater(numList);
            // call a command that lets you pick a number            
            int Usersearch;
            bool IsaNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                IsaNumber = int.TryParse(Console.ReadLine(), out Usersearch);
            } while (IsaNumber == false);
            NumberChecker(numList, Usersearch);
            Console.WriteLine("-------------------");
            Console.WriteLine("Begining of list");
            //Prints all the number in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");           
            //Gets rid of all odd numbers and sort the evens                   
            Console.WriteLine(" Sorted Evens only");
            OddKiller(ref numList);
            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");


            #endregion
        }
        private static void ThreeKiller(int[] number)
        {
             for (int i = 0; i < number.Length; i++)
            {
                if (number[i]% 3 == 0)
                {
                    number[i] = 0;
                    
                }                
            }
             foreach( var num in number)
            {
                Console.WriteLine(num);
            }
        }
        private static void OddKiller(ref List<int> numberList)
        {          
            numberList.RemoveAll(numberList => numberList% 2 != 0);
            numberList.Sort();
            NumberPrinter(numberList);
        }

        private static void SortArray(int[] number)
        {
            Array.Sort(number);
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
        }
        private static void NumberChecker(List<int> numberList, int searchNumber) 
        {
            if (numberList.Contains(searchNumber))
             {
                Console.WriteLine($"Yes the number is here");

            }
            else
            {
                Console.WriteLine($"We do not have that number");
            }
        }

        private static void Populater(List<int> numList)
        {
               while(numList.Count < 51) 
            {
                Random rng = new Random();
                var num = rng.Next(0, 50);

                numList.Add(num);


            }            
                

            
            
        }

        private static void Populater(int[] number)
        {
            //Populate the array with random number 0-50
            for(int i = 0; i < number.Length; i++)
            {
                Random rng = new Random();
                number[i] = rng.Next(0, 50);
            }
            
        }

        public static void ReverseArray(int[] number)
        {   
            
            Array.Reverse(number);
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
            
            
            
            /*
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            } */
            
        }



        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        } 
        
    }
}