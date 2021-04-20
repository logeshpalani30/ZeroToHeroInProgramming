using System;

namespace PlayingwithCSharp
{
    class Program
    {
        static void Main(string[] args)
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
            System.Console.WriteLine(revered_int);
        }
    }
    public class ReactableAndCircle{
        public static double FindAreaOfCircle()
        {
            return double.MaxValue;
        }
    }
}