using System;

namespace PlayingwithCSharp
{				
    public static class OverflowingMemory
    {
        public static void Overflow()
        {
            sbyte number = 127;
            Console.WriteLine(number);
            number += 1;
            Console.WriteLine(number);
            byte bytenumber = 255;
            Console.WriteLine(bytenumber);
            bytenumber += 1;
            Console.WriteLine(bytenumber);
            int intnumber = 2147483647;
            Console.WriteLine(intnumber);
            intnumber += 5;
            Console.WriteLine(intnumber);
            ushort shortnumber = 32767;
            System.Console.WriteLine("Before Increment : {0} ",short.MaxValue);
            shortnumber =+ 1;
            System.Console.WriteLine("After Increment : {0} ", shortnumber);
            float floatvalue = float.MaxValue;
            System.Console.WriteLine(floatvalue);
            floatvalue = float.MinValue;
            System.Console.WriteLine(floatvalue);
        }
           
    }
}