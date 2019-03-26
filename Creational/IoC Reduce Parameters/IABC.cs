using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Reduce_Parameters
{
    public interface IABC
    {
        IA A { get; }
        IB B { get; }
        IC C { get; }
    }
}
