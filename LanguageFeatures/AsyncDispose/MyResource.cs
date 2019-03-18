using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bnaya.Samples
{
    public class MyResource : IAsyncDisposable
    {
        public async ValueTask DisposeAsync()
        {
            await Task.Delay(200).ConfigureAwait(false);
            Console.WriteLine("Released");
        }
    }
}
