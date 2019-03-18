using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    public interface IBuilderABC: IBuilder
    {
        IBuilderBC A();
        IBuilderAC B();
        IBuilderAB C();
    }
}
