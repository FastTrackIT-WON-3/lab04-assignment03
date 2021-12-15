﻿using System;

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

            string result = ReadFromConsole("Introduceti textul (1):") ??
                            ReadFromConsole("Introduceti textul (2):") ??
                            ReadFromConsole("Introduceti textul (3):") ??
                            "Nu am continut";

            Console.WriteLine(result);
        }

        static string ReadFromConsole(string label)
        {
            Console.Write(label);
            string text = Console.ReadLine();

            return string.IsNullOrWhiteSpace(text)
                ? null
                : text;
        }
    }
}
