using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class ifpro
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            Console.Write("Enter the first number ");
            int firstnumber=int.Parse(Console.ReadLine());
            Console.Write("Enter the second number ");
            int second = int.Parse(Console.ReadLine());
            if (firstnumber > second)
            {
                Console.Write("The biggest number is { 0 }", firstnumber);
            }
            else
            {
                Console.Write(" The biggest number is {0}",second);
            }
        }
    }
}
