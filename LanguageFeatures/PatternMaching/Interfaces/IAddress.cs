using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public interface IAddress
    {
        string Country { get; }
        string State { get; }
        string City { get; }
    }
}
