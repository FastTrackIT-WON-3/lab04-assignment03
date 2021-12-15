using System;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            // && <- cand primul este false
            // || <- cand primul este true
            // conditie ? caz_true : caz_false
            // variantaNotNull ?? alternativaPtNull

            string text1, text2, text3;
            text1 = Console.ReadLine();
            string result = string.IsNullOrWhiteSpace(text1)
                ? (
                    string.IsNullOrWhiteSpace(text2 = Console.ReadLine())
                    ? (
                        string.IsNullOrWhiteSpace(text3 = Console.ReadLine())
                            ? "Nu am continut"
                            : text3
                      )
                    : text2
                  )
                : text1;

            Console.WriteLine(result);
        }
    }
}
