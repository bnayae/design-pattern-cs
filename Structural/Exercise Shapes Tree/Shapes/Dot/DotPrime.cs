using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class DotPrime : Line
    {
        public DotPrime(IDrawingChar drawingChar)
            : base(drawingChar, 1, CharStyle.Primary)
        {
        }
    }
}
