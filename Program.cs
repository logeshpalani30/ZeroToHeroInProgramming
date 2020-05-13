using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace PlayingwithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 10;
            MyRefMethod(ref num);
            Console.WriteLine(num);

            //LinkedList<int> ts = new LinkedList<int>();
            //ts.AddFirst(100);
            //ts.AddLast(10);
            //ts.AddAfter(ts.Find(10), 15);
            
            //Console.WriteLine(); 
            //Console.WriteLine(ts.ToString());
        }

        private static void MyRefMethod(ref int number)
        {
            number = number + 20;
            Console.WriteLine(number);
        }
    }
}