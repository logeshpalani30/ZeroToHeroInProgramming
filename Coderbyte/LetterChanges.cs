using System;

namespace PlayingwithCSharp
{
    public static class LetterChanges
    {
        public static void LetterChangesMethod(string str)
        {
            str = str.ToLower();
            var data = "";
            var vowles = "aeiou";

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ' || !Char.IsLetter(str[i]))
                {
                    var AsciiNumber = Convert.ToInt32(str[i]);
                    var changedchar = Convert.ToChar(AsciiNumber + 1);
                    if (vowles.Contains(changedchar))
                        changedchar = Char.ToUpper(changedchar);
                    data = data + changedchar.ToString();
                }
                else if (!Char.IsNumber(str[i]))
                {
                    data = data + str[i].ToString();
                }
                else
                { data = data + " "; }
            }
            System.Console.WriteLine(data);


        }
    }
}