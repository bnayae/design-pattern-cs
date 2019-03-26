﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Reduce_Parameters
{
    public class ABC: IABC
    {
        public ABC(IA a, IB b, IC c)
        {
            A = a;
            B = b;
            C = c;
        }

        public IA A { get; }
        public IB B { get; }
        public IC C { get; }
    }
}
