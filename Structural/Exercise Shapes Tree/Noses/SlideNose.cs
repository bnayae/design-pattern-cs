using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class Nose : IShape
    {
        private readonly IShape _dot;
        private readonly IShape _line;

        public Nose(
            [KeyFilter(Keys.DotPrime)]IShape dot,
            [KeyFilter(Keys.Line2Prime)]IShape line)
        {
            _dot = dot;
            _line = line;
        }

        public void Display(IOffseter offseter)
        {
            _dot.Display(offseter);
            _dot.Display(offseter);
            _line.Display(offseter);
        }
    }
}
