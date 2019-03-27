using System;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = Builder.Default.B().A();
            var b1 = builder.C();
            var b2 = Builder.Default.C();
            builder.Write();
            b1.Write();

            Console.ReadKey();
        }
    }
}
