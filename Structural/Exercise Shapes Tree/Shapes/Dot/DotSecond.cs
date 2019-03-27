using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class DotSecond : Line
    {
        public DotSecond(IDrawingChar drawingChar)
            : base(drawingChar, 1, CharStyle.Secondary)
        {
        }
    }
}
