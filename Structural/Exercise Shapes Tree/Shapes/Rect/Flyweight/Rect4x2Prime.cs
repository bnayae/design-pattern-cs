using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class Rect4x2Prime : Rect
    {
        public Rect4x2Prime(
            [KeyFilter(Keys.Line4Prime)]IShape data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
