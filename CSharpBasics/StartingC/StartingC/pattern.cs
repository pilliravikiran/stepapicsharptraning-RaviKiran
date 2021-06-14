using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class pattern
    {
        public static void Main()
        {
            Console.Write(" ENter a number");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }Console.WriteLine();
            }
        }
    }
}
