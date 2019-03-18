using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public interface IContext
    {
        void ChangeState(IStateDelegator state);
    }
}
