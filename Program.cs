using System;

namespace PlayingwithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(23456);
            System.Console.WriteLine(number);
            var result = (number%10)/1*10000;
            result = result+ ((number % 100) / 10) * 1000;
            result = result+ ((number % 1000) / 100) * 100;
            result = result +(((number%10000)/1000)*10);
            result = result +(((number%100000)/10000)*1);

            System.Console.WriteLine(result);
        }
    }
    public class ReactableAndCircle{
        public static double FindAreaOfCircle()
        {
            return double.MaxValue;
        }
    }
}