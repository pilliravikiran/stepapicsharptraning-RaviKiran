using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class SymmetricArray
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers in the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Entered Elements are");
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            bool symmetric = true;
            for(int k = 0; k < arr.Length/2; k++)
            {
                if (arr[k] != arr[n - k - 1])
                {
                    symmetric = false;
                    break;
                }

            }
            Console.WriteLine("Symmetric {0}",symmetric);
            



        }
    }
}
