using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates an array with ten pseudo-random elements for examples
            int[] Array10 = new int[] {1, 5, 7, 3, 0, 4, 6, 9, 1, 4 };

            //creates an array with  one hundred pseudo-random elements for examples
            int[] Array100 = new int[] { 4, 0, 7, 1, 0, 1, 9, 8, 7, 0, 9, 5, 0, 9, 3, 2, 9, 8, 3, 8, 1, 6, 1, 6, 2, 7, 8, 5, 5, 7, 6, 5, 8, 3, 6, 1, 3, 0, 0, 6, 1, 1, 9, 4, 0, 9, 8, 4, 9, 1, 4, 4, 4, 9, 5, 0, 7, 7, 7, 5, 4, 7, 7, 8, 0, 8, 8, 4, 4, 6, 3, 7, 4, 4, 2, 8, 2, 5, 3, 0, 3, 9, 1, 9, 5, 8, 7, 6, 3, 3, 1, 9, 5, 7, 7, 8, 3, 4, 1, 1 };
           

  
            // 1. An example of a constant O(1) method: 
            // Accessing a particular array element.

            int accessElement(int[] array, int element) {
                return array[element];
            }

            accessElement(Array10, 0);
            accessElement(Array100, 0);

            // No significant time difference between inputting Array10 or Array100

            // Because arrays are static and continuous, 
            // accessing a particular element takes the same amount of time,
            // no matter how large the array.



            // 2. An example of a linear O(n) method:
            // Tallying the quantity of a particular value in an array.

            int tallyArray(int[] array, int searchFor) 
            {
               
                int tally = 0;
                foreach (int i in array)
                {
                    if (i == searchFor)
                    {
                        ++tally;
                    }
                }

                return tally;
                 

            }
        
          tallyArray(Array10, 6);
          tallyArray(Array100, 6);

            // This method will always have to go through the entire array one time,
            // making this linear. So the longer the array the more time it takes in a linear relationship.



            // 3. An example of a quadratic O(n^2) method:
            // Sorting an array using a selection sort. 

            void SelectionSort(int[] array)
            {
                int i, j, min;
                for (i = 0; i < array.Length; i++)
                {
                    min = i;
                    for (j = 0; j < array.Length; j++)
                    {
                        if (array[j] > array[min])
                        {
                            min = j;
                            Swap(ref array[i], ref array[min]);
                        }
                    }
                }
            }
            //swapping method to help with SelectionSort()
           void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            // This method is O(n^2) complexity because,
            //for every additional element in the array,
            // the array must be passed through again to compare the values. 
            Console.ReadKey();
        }
    }
}
