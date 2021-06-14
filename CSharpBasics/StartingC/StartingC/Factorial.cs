using System;
using System.Numerics;
class Factorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        while (n > 0)
        {
            factorial *= n;
            n--;
        } 
        Console.WriteLine("n! = " + factorial);
    }
}