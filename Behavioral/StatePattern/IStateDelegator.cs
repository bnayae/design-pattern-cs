using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public interface IStateDelegator
    {
        IStateDelegator Execute(IContext context, DateTime now);
    }
}
