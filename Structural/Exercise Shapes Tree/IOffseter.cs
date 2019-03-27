using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public interface IOffseter
    {
        void Next();
        void Reset();
        IOffseter Shift(int x, int y);
    }
}
