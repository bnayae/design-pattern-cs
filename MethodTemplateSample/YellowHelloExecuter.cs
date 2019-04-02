using System;
using System.Collections.Generic;
using System.Text;

namespace MethodTemplateSample
{
    public class YellowHelloExecuter: HelloExecuter
    {
        protected override ConsoleColor Color => ConsoleColor.Yellow;

        //protected new void OnExecute()
        //{
        //    Console.WriteLine("Bye");
        //}
    }
}
