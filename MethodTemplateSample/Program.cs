using System;

namespace MethodTemplateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new HelloExecuter();

            e.Execute();

            Console.ReadKey();
        }
    }
}
