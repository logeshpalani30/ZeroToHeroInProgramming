namespace PlayingwithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class FindTwoDifferentMinimums
    {
        public static int FindMinimumValueWithMultipleOccurence()
        {
            var numbers = new int[] { 13, 12, 321, 61, 67, 34, 12 };
            var minNumber = numbers[0];
            foreach (var number in numbers)
            {
                if (minNumber > number)
                    minNumber = number;
            }
            System.Console.WriteLine(minNumber);
            return minNumber;
        }
    }
}