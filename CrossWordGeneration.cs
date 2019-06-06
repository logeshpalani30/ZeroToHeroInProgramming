using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingwithCSharp
{
    public class CrossWordGeneration
    {
        public int minValue = 0, maxValue = 5;
        public string[,] twoDimentionalArray = new string[5, 5];
        public int xPosition, yPosition;
        public int i = 0, arrayPoint = 0;
        public bool isLoop = true;
        public int loopCalculation = 0;
        Random random = new Random();
        public CrossWordGeneration()
        {
            for (var i = minValue; i < maxValue; i++)
            {
                for (var j = minValue; j < maxValue; j++)
                {
                    var valuePrint = twoDimentionalArray[i, j] = "*";
                    Console.Write(valuePrint);
                }
                System.Console.WriteLine("\n");
            }
            while (isLoop)
            {
                var numberPosition = random.Next(0, 4);
                var arrayLength = random.Next(0, 4);
                var lengthValue = (10 - (numberPosition - arrayLength)) / 2;

                for (int s = 0; s < lengthValue; s++)
                {
                    var insertedArray = twoDimentionalArray[arrayLength, numberPosition] = "_";
                    if (arrayLength < 4)
                    {
                        arrayLength++;
                    }

                    //Console.Write(insertedArray);
                }
                if (loopCalculation <= 10)
                {
                    isLoop = true;
                    loopCalculation++;
                }

                else
                {
                    for (var i = minValue; i < maxValue; i++)
                    {
                        for (var j = minValue; j < maxValue; j++)
                        {
                            var valuePrint = twoDimentionalArray[i, j];
                            Console.Write(valuePrint);
                        }
                        System.Console.WriteLine("\n");
                    }
                    isLoop = false;
                }
            }
        }
        public bool IsPositionValid(int xPosition, int yPosition)
        {
            return xPosition >= minValue && yPosition >= minValue && xPosition < maxValue && yPosition < maxValue;

        }
        public void CrossWordGenerationMethod(string words, int xPosition, int yPosition, int direction)
        {
            if (direction == 0)
            {
                try
                {
                    if (IsPositionValid(xPosition, yPosition))
                    {
                        var x = xPosition; var y = yPosition;
                        var placeWords = words.ToCharArray();
                        for (int i = 0; i < placeWords.Length; i++)
                        {
                            if (twoDimentionalArray[x, y] == "_" || twoDimentionalArray[x, y] == placeWords[i].ToString())
                            {
                                twoDimentionalArray[x, y] = placeWords[i].ToString();
                            }
                            else
                            {
                                Console.WriteLine(string.Format(" In this place already occupied {0} try another position", twoDimentionalArray[x, y]));
                                System.Console.Write("Do you want to see which positions are Free Enter 1 or Exit 2 :");
                                var freePositions = Convert.ToInt32(System.Console.ReadLine());
                                if (freePositions == 1)
                                {
                                    printMatrix();
                                }
                                else
                                    break;
                            }
                            y++;
                        }

                    }
                    else
                    {
                        Debug.Write("Invalid Positions ");
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }

            }
            else if(direction == 1)
            {
                if (IsPositionValid(xPosition, yPosition))
                {
                    var x = xPosition; var y = yPosition;
                    var placeWords = words.ToCharArray();
                    for (int i = 0; i < placeWords.Length; i++)
                    {
                        if (twoDimentionalArray[x, y] == "_" || twoDimentionalArray[x, y] == placeWords[i].ToString())
                        {
                            twoDimentionalArray[x, y] = placeWords[i].ToString();
                        }
                        else
                        {
                            Console.WriteLine(string.Format(" In this place already occupied {0} try another position", twoDimentionalArray[x, y]));
                            System.Console.Write("Do you want to see which positions are Free Enter 1 or Exit 2 :");
                            var freePositions = Convert.ToInt32(System.Console.ReadLine());
                            if (freePositions == 1)
                            {
                                printMatrix();
                            }
                            else
                                break;
                        }
                        x++;
                    }
                }
                else
                {
                    Debug.Write("Invalid Positions ");
                }
            }
        }

        public void printMatrix()
        {
            for (int i = minValue; i < maxValue; i++)
            {
                for (int j = minValue; j < maxValue; j++)
                {
                    Console.Write(twoDimentionalArray[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}







