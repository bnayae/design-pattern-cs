using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Sample
{
    public class Goodbye : IGreet
    {
        public void Greet() => Console.WriteLine("Goodbye");
    }
}
