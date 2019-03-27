using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class Rect2x2Second : Rect
    {
        public Rect2x2Second(
            [KeyFilter(Keys.Line2Second)]IShape data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
