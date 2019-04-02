using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MethodTemplateSample
{
    public abstract class ExecBase : IExecBase
    {
        public void Execute()
        {
            var sw = Stopwatch.StartNew();
            try
            {
                OnExecute();
            }
            finally
            {
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        protected abstract void OnExecute();
    }
}
