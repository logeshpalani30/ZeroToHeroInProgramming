using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingwithCSharp
{
    public class NormalizeArray
    {
        // static void Main(string[] args)
        // {
        //     int[] numbers = { 5, 7, 4, 3, 3, 1 };
        //     // int[] numbers = {5,7,4,3,3,1};
        //     // int[] numbers = {5,7,4,3,3,1};
        //
        //     DoNormalization(numbers);
        //
        //     foreach (var number in numbers)
        //     {
        //         Console.Write(number);
        //     }
        // }

        public  int[] DoNormalization(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (j <= numbers.Length)
                    {
                        if (numbers[i] == numbers[j] && i != j)
                        {
                            numbers[i] = i;

                            for (int l = i + 1; l < numbers.Length; l++)
                            {
                                if (numbers[i] == numbers[l] && i != l)
                                {
                                    numbers[i] = numbers[i] + 1;
                                    l = -1;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number);
            }

            return numbers;
        }
    }
}