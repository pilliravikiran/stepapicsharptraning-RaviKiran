using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class GetSet
    {
        public int X{get;set;}
        public int Y { get; set; }

        public GetSet(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        

    }
    class Test
    {
        public  static void Main()
        {
            GetSet tag = new GetSet(5,6);
            Console.WriteLine("The X value is {0}",tag.X);
            Console.WriteLine("The X value is {0}", tag.Y);


        }
    }
}
