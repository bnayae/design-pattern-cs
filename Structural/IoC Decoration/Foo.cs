using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Decoration
{
    public class Foo : IFoo
    {
        public void Exec(string mesasage)
        {
            Console.WriteLine(mesasage);
        }
    }
}
