using System;

namespace PlayingwithCSharp
{
    public class Print1To100MissingNumberInArrayWithoutLoop
    {

        public Print1To100MissingNumberInArrayWithoutLoop()
        {

        }
        public static void MissingNumber()
        {

            int[] givenArray = new int[99];
            int incrementValue = 1, arrayPosion = 0;
            #region Assign Value to Array
            givenArray[0] = 1;
            givenArray[1] = 46;
            givenArray[2] = 34;
            givenArray[3] = 23;
            givenArray[4] = 26;
            #endregion
            Array.Sort(givenArray);

        Loop:
            var isPosition = Array.IndexOf(givenArray, incrementValue);
            if(isPosition == -1)
            {
                System.Console.Write(incrementValue + " ");
                if (incrementValue != 100)
                {
                    arrayPosion++;
                    incrementValue++;
                    goto Loop; 
                }
                else
                {
                        System.Console.WriteLine("\nMissing Value 1 to 100 Printed Above");
                }
            }
            else 
            {
                    if (incrementValue == 100)
                    {
                        System.Console.WriteLine("\nMissing Value 1 to 100 Printed Above");
                    }
                    else
                    {
                        incrementValue++;
                        goto Loop;
                    }
            }
            Console.ReadLine();
        }
    }
}


// Input : Given Array
// 1, 46, 34, 23, 26
// Output : Missing element
// 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 24 25 27 28 29 30 31 32 33 35 36 37 38 39 40 41 42 43 44 45 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95
// 96 97 98 99 100
// Missing Value 1 to 100 Printed Above