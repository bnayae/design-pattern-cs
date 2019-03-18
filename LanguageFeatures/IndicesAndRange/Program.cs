using System;
using System.Collections.Generic;

using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            Console.WriteLine($"The last word is {words[^1]}");
            string[] quickBrownFox = words[1..4];
            Range r = 1..4;
            quickBrownFox = words[r];

            var lazyDog = words[^2..^0];

            var allWords = words[..]; // contains "The" through "dog".
            allWords = words[Range.All]; // contains "The" through "dog".

            var firstPhrase = words[..4]; // contains "The" through "fox"

            var lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
            lastPhrase = words[Range.StartAt(6)]; // contains "the, "lazy" and "dog"
            Console.ReadKey();
        }
    }
}


