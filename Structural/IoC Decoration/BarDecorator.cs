using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bnaya.Samples
{
    public class BarDecorator : IFoo
    {
        private readonly IFoo _origin;

        public BarDecorator(IFoo origin)
        {
            _origin = origin;
        }

        public void Exec(string mesasage)
        {
            try
            {
                Console.WriteLine("#####################");
                _origin.Exec(mesasage);
            }
            finally
            {
                Console.WriteLine($"####################");
            }
        }
    }
}
