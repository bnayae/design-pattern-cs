using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Bnaya.Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using (var r = new MyResource())
            {
                Console.WriteLine("Executing");
            }
            Console.WriteLine("Disposed");

            Console.ReadKey();
        }
    }
}
