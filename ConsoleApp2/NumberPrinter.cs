using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NumberPrinter
    {
        public static void PrintNumbers(int upperBound, Dictionary<int, string> numberWordPairs)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                string result = "";
                foreach (var pair in numberWordPairs)
                {
                    if (i % pair.Key == 0)
                    {
                        result += pair.Value + " ";
                    }
                }

                if (string.IsNullOrEmpty(result.Trim()))
                {
                    Console.WriteLine(i.ToString());
                }
                else
                {
                    Console.WriteLine(result.Trim());
                }
            }
        }
    }
}
