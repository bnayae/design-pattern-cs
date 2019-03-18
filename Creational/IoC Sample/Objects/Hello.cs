using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Sample
{
    public class Hello : IGreet
    {
        public void Greet() => Console.WriteLine("Hello");
    }
}
