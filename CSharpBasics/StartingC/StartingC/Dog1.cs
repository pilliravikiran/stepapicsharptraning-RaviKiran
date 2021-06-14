using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class Dog1
    {

        string name;
        int age;
        int length;
        bool isMale=true;
        static void Main()
        {
            Dog1 dog = new Dog1();
            dog.name = "kiran";
            Console.WriteLine("Dog's name is: " + dog.name);
            Console.WriteLine("Dog's age is: " + dog.age);
            Console.WriteLine("Dog's length is: " + dog.length);
            Console.WriteLine("Dog is male: " + dog.isMale);
        }
    }
}
