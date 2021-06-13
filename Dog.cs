using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class Dog
    {
        private String name;
       
        public Dog(String name)
        {
            Console.WriteLine("the firstdog name is {0}", name);


        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        static void Main()
        {
            String firstdogname = null;
            Console.Write("ENtter the name of the first dog");
            firstdogname = Console.ReadLine();
            Dog firstdog = new Dog(firstdogname);


            

            




        }
    }
}
