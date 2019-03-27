using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Goodbye : IGreet
    {
        public void Greet() => Console.WriteLine("Goodbye");
    }
}
