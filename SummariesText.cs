using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    public class SummariesText
    {
        public static void SummariesTextDisplay(string text)
        {
            var maxLength = 20;
            if (text.Length < maxLength)
                Console.WriteLine(text);
            else
            {
                var wordsList = new List<string>();
                var words = text.Split(' ');
                var wordLength = 0;
                foreach (var item in words)
                {
                    wordsList.Add(item);
                    wordLength += item.Length + 1;
                    if (wordLength > maxLength)
                        break;
                }

                var summary = String.Join(' ', wordsList) + "...";
                Console.WriteLine(summary);
            }
        }
    }
}
