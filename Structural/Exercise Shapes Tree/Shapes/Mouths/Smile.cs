using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class Smile : IShape
    {
        private readonly IShape _dot;
        private readonly IShape _line;

        public Smile(
            [KeyFilter(Keys.DotPrime)]IShape dot,
            [KeyFilter(Keys.Line4Prime)]IShape line)
        {
            _dot = dot;
            _line = line;
        }

        public void Display(IOffseter offseter)
        {
            var offseted = offseter.Shift(4, 0);
            _dot.Display(offseter);
            _dot.Display(offseted);
            _line.Display(offseter);
        }
    }
}
