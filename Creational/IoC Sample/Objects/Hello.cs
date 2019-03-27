using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Hello : IGreet
    {
        public void Greet() => Console.WriteLine("Hello");
    }
}
