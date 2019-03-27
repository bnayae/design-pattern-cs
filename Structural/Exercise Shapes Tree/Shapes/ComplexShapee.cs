using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Bnaya.Samples
{
    public abstract class ComplexShape : ShapeChildren
    {
        private readonly (IShape Shape, int ShiftX, int ShiftY)[] _data; // flyweight (don't create line per draw)

        public ComplexShape(
            params (IShape Shape, int ShiftX, int ShiftY)[] data)
            : base(ImmutableList.CreateRange(data.Select(m => m.Shape)))
        {
            _data = data;
        }

        public override void Display(IOffseter offseter)
        {
            foreach ((IShape shape, int shiftX, int shiptY) in _data)
            {
                var offset = offseter.Shift(shiftX, shiptY);
                shape.Display(offset);
            }
            ClickToContinue();
            base.Display(offseter);
        }
    }
}
