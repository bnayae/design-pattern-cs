using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class ParkState : IStateDelegator
    {
        public IStateDelegator Execute(IContext context, DateTime now)
        {
            if (now.Hour < 19 && now.Hour > 8)
            {
                Console.WriteLine("At Park");
                return this;
            }
            IStateDelegator state = new HomeState();
            state = state.Execute(context, now);
            context.ChangeState(state);
            return state;
        }
    }
}
