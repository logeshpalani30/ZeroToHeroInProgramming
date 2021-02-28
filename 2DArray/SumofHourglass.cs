namespace PlayingwithCSharp
{
    public class SumofHourglass
    {
        int[][] arr;
        int maxValue = -9*7;
        int tempMaxValue = 0;

        public SumofHourglass()
        {
            
        }

        public int GetMaxSumofHourglass(int[][] arr)
        {
            this.arr =  arr;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    tempMaxValue = arr[i][j]
                        + arr[i][j + 1]
                        + arr[i][j + 2]
                        + arr[i + 1][j + 1]
                        + arr[i + 2][j]
                        + arr[i + 2][j + 1]
                        + arr[i + 2][j + 2];

                    maxValue = maxValue < tempMaxValue ? tempMaxValue : maxValue;
                }
            }
            //Console.WriteLine(maxValue);
            return maxValue;
        }
    }
}
