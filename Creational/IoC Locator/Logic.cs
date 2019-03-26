using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace IoC_Reduce_Parameters
{
    public class Logic
    {
         private readonly IComponentContext _ioc;
       public Logic(IComponentContext ioc)
        //public Logic(IA a, IB b, IC c, ID d, IE e)
        {
            //var a = ioc.Resolve<IA>();
            _ioc = ioc;
        }


        public void Exec()
        {
            var b = _ioc.Resolve<IB>();
            _ioc.UseC();

        }

    }
}
