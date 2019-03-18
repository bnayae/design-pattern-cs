using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public readonly ref struct Polygon
    {
        public Polygon(/* won't changed */in Span<(int x, int y)> border)
        {
            Border = border;
        }

        // required readonly ref struct
        public Span<(int x, int y)> Border { get; /* set; // won't compile */ } 
    }
}
