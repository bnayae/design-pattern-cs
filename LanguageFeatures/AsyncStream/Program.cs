using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bnaya.Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);

            }

            Console.ReadKey();
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100).ConfigureAwait(false);
                yield return i;
            }
        }
    }
}
