using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Sample
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message, Exception ex);
    }
}
