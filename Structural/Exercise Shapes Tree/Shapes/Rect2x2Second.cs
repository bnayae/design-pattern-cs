using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class Rect2x2Second : Rect
    {
        private readonly Line _data; // flyweight (don't create line per draw)

        public Rect2x2Second(
            [KeyFilter("L2Sec")]Line data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
