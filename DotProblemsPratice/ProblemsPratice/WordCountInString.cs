using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPratice
{
    internal class WordCountInString
    {
        public static void wordCountInString(string a)
        {
            int wordCount = 1;
            if(a.Length == 0)
            {
                Console.WriteLine("No words in string");
            }
            else
            {
                foreach (char c in a)
                { 
                    if (c == ' ' )
                    {
                        wordCount++;
                    }
                }
                
                Console.WriteLine(wordCount);
            }

        }
    }
}
