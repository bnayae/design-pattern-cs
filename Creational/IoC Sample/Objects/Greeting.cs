using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.Indexed;

namespace IoC_Sample
{
    public class Greeting : IGreet
    {
        private readonly IIndex<DayOfWeek, IGreet> _greetMap;

        public Greeting(IIndex<DayOfWeek , IGreet> greetMap)
        {
            _greetMap = greetMap;
        }
        public void Greet()
        {
            if(_greetMap.TryGetValue(DateTime.Now.DayOfWeek, out IGreet greet))
                greet.Greet();
        }
    }
}
