using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Decoration
{
    public class Manager: IManager
    {
        private readonly IFoo _foo;

        public Manager(IFoo foo)
        {
            _foo = foo;
        }

        public void Run() => _foo.Exec("From Manager");

    }
}
