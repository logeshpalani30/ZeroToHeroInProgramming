using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    public class SummariesText
    {
        public static string SummariesTextDisplay(string text)
        {
            var maxLength = 20;
            if (text.Length < maxLength)
                return text;
            
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

            return String.Join(' ', wordsList) + "...";
        }
    }
}
// Input : The some part of really really really reallay course have some issues and some other
// Output : The some part of really...
