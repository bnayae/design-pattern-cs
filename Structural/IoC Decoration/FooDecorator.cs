using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bnaya.Samples
{
    public class FooDecorator : IFoo
    {
        private readonly IFoo _origin;
        private readonly ISetting _setting;

        public FooDecorator(IFoo origin, ISetting setting)
        {
            _origin = origin;
            _setting = setting;
        }

        public void Exec(string mesasage)
        {
            if (!_setting.Active)
            {
                _origin.Exec(mesasage);
                return;
            }

            var sw = Stopwatch.StartNew();
            try
            {
                Console.WriteLine("----------- Before Exec ---------");
                _origin.Exec(mesasage);
            }
            finally
            {
                sw.Stop();
                Console.WriteLine($"----------- After Exec  {sw.Elapsed} ---------");
            }
        }
    }
}
