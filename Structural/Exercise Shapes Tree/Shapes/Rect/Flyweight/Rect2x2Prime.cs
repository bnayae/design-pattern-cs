using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class Rect2x2Prime : Rect
    {
        public Rect2x2Prime(
            [KeyFilter(Keys.Line2Prime)]IShape data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
