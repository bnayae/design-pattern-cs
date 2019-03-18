using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Context: IContext
    {
        private IStateDelegator _state;

        public Context(IStateDelegator state)
        {
            _state = state;
        }
        void IContext.ChangeState(IStateDelegator state)
        {
            _state = state;
        }

        public void Move(DateTime now)
        {
            _state.Execute(this, now);
        }
    }
}
