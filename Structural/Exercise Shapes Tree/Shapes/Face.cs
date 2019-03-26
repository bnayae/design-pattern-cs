using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public abstract class Face : IShape
    {
        private readonly (IShape Shape, int ShiftX, int ShiftY)[] _data; // flyweight (don't create line per draw)

        public Face(
            params (IShape Shape, int ShiftX, int ShiftY)[] data)
        {
            _data = data;
        }

        public void Display(IOffseter offseter)
        {
            foreach ((IShape shape, int shiftX, int shiptY) in _data)
            {
                var offset = offseter.Shift(shiftX, shiptY);
                shape.Display(offset);
            }
        }
    }
}
