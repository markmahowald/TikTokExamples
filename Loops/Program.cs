using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char[]> arraysToSort = new List<char[]>()
            {
                new char[7]{'z','y','x','w','v','u','t'}
                , new char[3]{'c', 'b', 'a'}
            };

            
            // loop through each array, calling the sort method. 
            // this is a foreach loop and will go through each item in the list. 
            foreach (char[] array in arraysToSort)
            {
                System.Console.WriteLine($"Original array order -{new string( array)}");
                SortArray(array);
                System.Console.WriteLine($"sorted array = {new string( array)}");
            }

            
        }
        public static void SortArray(char[] arrayToSort)
        {
            
            
            //bool is a data type that can be true or false. 
            bool sorted = true;

            //this is a do-while loop.  the condition of the loop is evaluated at the end of the loop, which is good, as the condition is set to true initially. 
            do
            {
                sorted = true;
                System.Console.WriteLine(new string("Entering the sort with "+new string(arrayToSort)));
                for (var i = 0; i < arrayToSort.Length-1; i++)
                {
                    System.Console.WriteLine($"char at {i} - {arrayToSort[i]}");
                    System.Console.WriteLine($"char at {i+1} - {arrayToSort[i+1]}");
                    if ( arrayToSort[i] > arrayToSort[i+1])
                    {                      
                        System.Console.WriteLine("swap them");
                        //if the first char is greater (i.e. comes later in the ascii alphabet), swap them. 
                        char tempChar = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i+1];
                        arrayToSort[i+1] = tempChar;
                        sorted = false;
                    }
                }
            }while (!sorted);

              
        }

        
    }
}
