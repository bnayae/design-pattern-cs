using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree
{
    public interface IOffseter
    {
        void Next();
        void Reset();
        IOffseter Shift(int x, int y);
    }
}
