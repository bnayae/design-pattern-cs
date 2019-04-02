using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class HomeState : IStateDelegator
    {
        public IStateDelegator Execute(IContext context, DateTime now)
        {
            if (now.Hour < 8 || now.Hour > 19)
            {
                Console.WriteLine("At Home");
                return this;
            }
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    {
                        IStateDelegator state = new WorkState();
                        state = state.Execute(context, now);
                        context.ChangeState(state);
                        return state;
                    }
              
                default:
                    {
                        IStateDelegator state = new ParkState();
                        state = state.Execute(context, now);
                        context.ChangeState(state);
                        return state;
                    }
            }
        }
    }
}
