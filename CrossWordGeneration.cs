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
        public int i = 0;
        public CrossWordGeneration()
        {
            for (var i = minValue; i < maxValue; i++)
            {
                for (var j = minValue; j < maxValue; j++)
                {
                    var valuePrint = twoDimentionalArray[i, j] = "*";
                    //Console.Write(valuePrint);
                }
                //System.Console.WriteLine("\n");
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
                            if (twoDimentionalArray[x, y] == "*")
                            {
                                twoDimentionalArray[x, y] = placeWords[i].ToString();
                            }
                            //else if(twoDimentionalArray[x,y] == )
                            else
                            {                                                          
                                Console.WriteLine($" in this place already occupied {twoDimentionalArray[x, y]} try another position");
                                System.Console.Write("Do you want to see which positions are Free Enter 1 or Exit 2 :");
                                var freePositions =Convert.ToInt32(System.Console.ReadLine());
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
            else
            {
                if (IsPositionValid(xPosition, yPosition))
                {
                    var x = xPosition; var y = yPosition;
                    var placeWords = words.ToCharArray();
                    for (int i = 0; i < placeWords.Length; i++)
                    {
                        twoDimentionalArray[x, y] = placeWords[i].ToString();
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







