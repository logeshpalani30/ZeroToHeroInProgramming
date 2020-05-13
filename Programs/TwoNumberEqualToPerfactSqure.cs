using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PlayingwithCSharp
{
    public class TwoNumberEqualToPerfact
    {
        public static void TwoNumberEqualToPerfactMathod()
        {
            long num0, num1;
            //string a;
            var list = new List<int>();
            double num0_squre, num1_squre, add, root;
            for (long i = 10000; i <= 99999; i++)
            {
                num0 = i;
                for (long j = i; j < 99999; j++)
                {
                    num1 = j;
                    num0_squre = Math.Pow(num0, 2);
                    num1_squre = Math.Pow(num1, 2);
                    add = num0_squre + num1_squre;
                    root = Math.Sqrt(add);
                    if ( root == Math.Abs(root))
                    {
                        list.Add((int)root);
                    }
                }
            }
            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}