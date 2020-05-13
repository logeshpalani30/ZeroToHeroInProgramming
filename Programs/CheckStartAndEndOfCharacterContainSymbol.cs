using System;
using System.Collections;

namespace PlayingwithCSharp
{
    public class CheckStartAndEndOfCharacterContainSymbol
    {
        public static void  CheckStartAndEndOfCharacterContainSymbolMathod()
        {
            string trueValue = "+b*-][;;=][;[";
            for (int i = 0; i < trueValue.Length; i++)
            {
                if (char.IsLetter(trueValue[i]))
                {
                    if (i == 0 || i == trueValue.Length - 1 || trueValue[i - 1] == '*' && trueValue[i + 1] == '*')
                    {
                       System.Console.WriteLine("isValid");
                    }
                }
            }

            
        }
    }
}
// input : +*b*-][;;=][;[
// output : isValid     
