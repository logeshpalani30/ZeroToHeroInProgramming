
using System;

namespace PlayingwithCSharp
{
    class ReverseInteger
    {
        static int DoReverse()
        {
            var number = Convert.ToInt32(23456);
            System.Console.WriteLine(number);
            var revered_int= 0;

            while (true)
            {
                revered_int= (revered_int*10)+number%10;
                number = number/10;
                
                if (number==0)break;
            }
           return revered_int;
        }
    }
}