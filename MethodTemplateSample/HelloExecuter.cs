using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplateSample
{
    public class HelloExecuter : ExecBase
    {
        protected sealed override void OnExecute()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine( "Hello");
        }

        protected virtual ConsoleColor Color { get; } = ConsoleColor.White;
    }
}
