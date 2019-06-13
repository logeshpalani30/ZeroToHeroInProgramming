using System;

namespace PlayingwithCSharp
{
    public static class GreatestCommonDivisor
    {
        public static int GCD(int x, int y)
        {
            if (x == 0)
                return y;
            return GCD(y % x, x);
        }
    }
}
// Input 
// 45,35
// Output
// 5
