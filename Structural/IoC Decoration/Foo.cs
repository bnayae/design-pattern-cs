using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Foo : IFoo
    {
        public void Exec(string mesasage)
        {
            Console.WriteLine(mesasage);
        }
    }
}
