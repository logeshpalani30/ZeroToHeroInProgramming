using System;

namespace PlayingwithCSharp
{
    public class SringIsSubstringOfAnotherString
    {
        public void CoronaVirusFinder()
        {
            var virusComposition = Console.ReadLine();
            var numberOfPeople = int.Parse(Console.ReadLine());
            var bloodCompositions = new string[numberOfPeople];
            
            for (int i = 0; i < numberOfPeople; i++)
            {
                var name = System.Console.ReadLine();
                bloodCompositions[i] = name;
            } 

            foreach (var bloodComposition in bloodCompositions)
            {
                FindPersonAffectedOrNot(virusComposition, bloodComposition);
            }
        }

        private static void FindPersonAffectedOrNot(string virusComposition, string bloodComposition)
        {
            var charFoundIndex = 0;
            if(bloodComposition.Length==0)
            {
                System.Console.WriteLine("POSITIVE");
                return;
            }    
            if(virusComposition.Length==0)  
            {
                System.Console.WriteLine("NEGATIVE");
                return;
            }

            for (int i = 0; i < bloodComposition.Length; i++)
            {
                for (int j = charFoundIndex; j < virusComposition.Length; j++)
                {
                    if (bloodComposition[i] == virusComposition[j])
                    {
                        charFoundIndex = j;
                        if (bloodComposition.Length - 1 == j)
                        {
                            System.Console.WriteLine("POSITIVE");
                            return;
                        }
                        break;
                    }
                    else{
                        if (virusComposition.Length - 1 == j)
                        {
                            System.Console.WriteLine("NEGATIVE");
                            return;
                        }
                    }
                }
            }
        }
    }
}