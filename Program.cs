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

            Print1To100MissingNumberInArrayWithoutLoop.MissingNumber();
            

            #region x
            //CheckStartAndEndOfCharacterContainSymbol.CheckStartAndEndOfCharacterContainSymbolMathod();
            #endregion
            #region Perfact Squre
            //TwoNumberEqualToPerfact.TwoNumberEqualToPerfactMathod();
            
            #endregion
            #region CrossWordGenerator  
            // int minValue = 0, maxValue = 4;
            // bool isValid = true;
            // bool toAdd = true;
            // var planeOption = 0;
            // var xPosition = 0;
            // var yPosition = 0;
            // var words = "";
            // CrossWordGeneration cross = new CrossWordGeneration();
            // System.Console.WriteLine("Wellcome Crossword");
            // while (toAdd)
            // {
            //     isValid = true;
            //     while (isValid)
            //     {
            //         Console.Write($"Choose Horizondal = {minValue} and Vertical = 1 Plane : ");
            //         planeOption = Convert.ToInt32(Console.ReadLine());
            //         if (planeOption == 0 || planeOption == 1)
            //             isValid = false;
            //         else
            //         {
            //             Console.WriteLine("Enter Horizontal = 0 or Vertical = 1, Other Datatype Not allowed");
            //             isValid = true;
            //         }
            //     }
            //     System.Console.WriteLine($"Enter Position \n Minimum Value = {minValue} & Maximum Value = {maxValue}");
            //     isValid = true;
            //     while (isValid)
            //     {
            //         System.Console.Write("Enter X Position : ");
            //         xPosition = Convert.ToInt32(Console.ReadLine());
            //         if (xPosition >= minValue || xPosition <= maxValue)
            //             isValid = false;
            //         else
            //         {
            //             System.Console.WriteLine($"Enter Position \n Minimum Value = {minValue} & Maximum Value = {maxValue}");
            //             isValid = true;
            //         }
            //     }
            //     isValid = true;
            //     while (isValid)
            //     {
            //         System.Console.Write("Enter Y Position : ");
            //         yPosition = Convert.ToInt32(Console.ReadLine());
            //         if (yPosition >= minValue || yPosition <= maxValue)
            //             isValid = false;
            //         else
            //         {
            //             System.Console.WriteLine($"Enter Position \n Minimum Value = {minValue} & Maximum Value = {maxValue}");
            //             isValid = true;
            //         }
            //     }
            //     isValid = true;
            //     while (isValid)
            //     {
            //         Console.Write("Enter Words : ");
            //         words = Console.ReadLine().ToString();
            //         var wordsCount = words.Length;
            //         if (planeOption == 0)
            //         {
            //             var xPositionCount = (maxValue + 1) - xPosition;
            //             if (wordsCount <= xPositionCount)
            //             {
            //                 isValid = false;
            //             }
            //             else
            //             {
            //                 Console.WriteLine($"Enter {xPositionCount} Character");
            //                 isValid = true;
            //             }
            //         }
            //         else
            //         {
            //             var yPositionCount = (maxValue + 1) - yPosition;
            //             if (wordsCount <= yPositionCount)
            //             {
            //                 isValid = false;
            //             }
            //             else
            //             {
            //                 Console.WriteLine($"Enter {yPositionCount} Character");
            //                 isValid = true;
            //             }
            //         }
            //     }

            //     Console.WriteLine("Well Alomost Finished");

            //     cross.CrossWordGenerationMethod(words, xPosition, yPosition, planeOption);

            //     Console.WriteLine("Do you want to add more \n Option 1 : Add \n Option 2 : Exit to Print Array");
            //     var addValue = Convert.ToInt32(Console.ReadLine());
            //     if (addValue == 1)
            //         toAdd = true;
            //     else
            //         toAdd = false;
            // }

            // cross.printMatrix();
            #endregion 
            #region GCD
            // var dcdValue = GreatestCommonDivisor.GCD(45, 35);
            // Console.WriteLine(dcdValue);
            #endregion
            #region NumberToWord     
            //Console.WriteLine(NumberToWordConversion(1453521));
            //var numberToWord = NumberToWord.ConvertNumbertoWords(3056);
            //Console.WriteLine(numberToWord);
            #endregion
            #region Memory OverFlow     
            //OverflowingMemory.Overflow();
            #endregion
            #region Split Full Name Without Function
            // FullNametoSplitSeparateNames();
            #endregion
            //Program.ThreadRun();
            Console.ReadLine();
        }

        public static string NumberToWordConversion(long numberValue)
        {
            var wordsValue = "";
            if (numberValue == 0)
                Console.WriteLine("Entered Value is Zero");

            if (numberValue / 100000 > 0)
            {
                wordsValue += NumberToWordConversion(numberValue / 100000) + " Lahks";
                numberValue = numberValue % 100000;
            }
            if (numberValue / 1000 > 0)
            {
                wordsValue += NumberToWordConversion(numberValue / 1000) + " Thousand";
                numberValue = numberValue % 1000;
            }
            if (numberValue / 100 > 0)
            {
                wordsValue += NumberToWordConversion(numberValue / 100) + " Hundred";
                numberValue = numberValue % 100;
            }
            if (numberValue > 0)
            {
                var valueSingleDigit = new string[] { ":)", " One", " Two", " Three", " Four", " Five", " Six", " Sevan", " Eight", " Nine", " Ten", " Eleven", " Twovle", " Thirtyteen", " Fourty", " Fifty", " Sixty", " Seventeen", " Eighteen", " Nineteen" };
                var valueDoubleDigit = new string[] { ":)", " Ten", " Twoenty", " Thirty", " Fourty", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };
                if (numberValue < 20)
                    wordsValue += valueSingleDigit[numberValue];
                else if (numberValue / 10 > 0)
                {
                    wordsValue += valueDoubleDigit[numberValue % 10];
                    if (numberValue / 10 > 0)
                        wordsValue += valueSingleDigit[numberValue / 10];
                }
            }
            return wordsValue;
        }
        public static bool stopLoop = true; // by default value is set to true
        public static void ThreadRun()
        {
            new Thread(() =>
            {
                Console.WriteLine("Loop started"); while (stopLoop) ;
                Console.WriteLine("Loop ended");
            }).Start();
            // loop runs until the stopLoop field is set to false
            Thread.Sleep(1000);
            stopLoop = false;
            Console.WriteLine("value set to false.");
        }
        public static void FullNametoSplitSeparateNames()
        {
            string str = "Logesh Palani";
            ArrayList arrayList = new ArrayList();
            string Temp = "";
            for (var i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')
                {
                    Temp = Temp + str[i];
                    if (i + 1 == str.Length)
                    {
                        arrayList.Add(Temp);
                        Temp = String.Empty;
                    }

                }
                else
                {
                    arrayList.Add(Temp);
                    Temp = String.Empty;
                }


            }
            //var inte = arrayList.Count;
            for (int i = 0; i < arrayList.Count; i++)
            {
                System.Console.WriteLine(arrayList[i]);
            }

            //  Console.ReadLine();
        }
    }
}
/*          int[] [] jaggedArray = new int[6][];           
            jaggedArray[0] = new int[4];
            jaggedArray[0][3] = 3;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                var innerArray = jaggedArray[i];
                for (int j = 0; j <innerArray.Length; j++)
                {
                    Console.Write(innerArray[j]+" ");
                }
                Console.WriteLine("\n");
            }          
            int[] arrary = new int[3];
            arrary[0] = 1;
            arrary[1] = 1;
            arrary[2] = 1;
            
            System.Console.WriteLine(arrary.Length);
            byte a = 1;
            byte b = 2;
            Console.WriteLine(!(a == b ));
 */