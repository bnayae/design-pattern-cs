using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public interface IBuilderABC: IBuilder
    {
        IBuilderBC A();
        IBuilderAC B();
        IBuilderAB C();
    }
}
