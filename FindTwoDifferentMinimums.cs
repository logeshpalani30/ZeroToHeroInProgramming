using System;

namespace PlayingwithCSharp
{
    public class FindTwoDifferentMinimums
    {
        public static int FindMinimumValueWithMultipleOccurence()
        {
            var numbers = new int[] { 13, 12, 321, 61, 67, 34, 14, 61 };
            var funcArray = new int[numbers.Length];

            Array.Copy(numbers,funcArray, numbers.Length);
            
            var minNumber = funcArray[0];
            
            minNumber = FindRecurively(funcArray);
            
            System.Console.WriteLine(minNumber);
            return minNumber;
        }

        private static int FindRecurively(int[] funcArray, int minNumber=0)
        {
            if (minNumber==0){
                minNumber = funcArray[0];
            }
            else{
                return minNumber;
            }

            foreach (var func in funcArray)
            {
                if (minNumber > func)
                    minNumber = func;
            }
            var count =0;
            for (int j = 0; j <funcArray.Length ; j++)
            {
                if (minNumber == funcArray[j])
                {
                    count+=1;
                }
            }
            if (count<2)
            {
              int[] newArray = new int[funcArray.Length -count];
              count =0;
              for (int i = 0; i < funcArray.Length; i++)
              {
                  if (minNumber != funcArray[i])
                  {
                    newArray[count]=funcArray[i]; 
                    count+=1;
                  }
              }
              count=0;
              funcArray =new int[newArray.Length];
              Array.Copy(newArray,funcArray, newArray.Length);
              minNumber = FindRecurively(funcArray);
              FindRecurively(funcArray, minNumber);
            }
            return minNumber;
        }
    }
}