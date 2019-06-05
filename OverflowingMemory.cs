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
            checked
            {
                byte bytenumber = 255;
                Console.WriteLine(bytenumber);
                bytenumber += 1;
                Console.WriteLine(bytenumber);
            }
            
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
// Output
// 127
// -128
// 255
// 0
// 2147483647
// -2147483644
// Before Increment : 32767
// After Increment : 1
// 3.402823E+38
// -3.402823E+38
// Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow.
//    at PlayingwithCSharp.OverflowingMemory.Overflow() in C:\Users\logesh\PlayingwithCSharp\OverflowingMemory.cs:line 17
//    at PlayingwithCSharp.Program.Main(String[] args) in C:\Users\logesh\PlayingwithCSharp\Program.cs:line 12

