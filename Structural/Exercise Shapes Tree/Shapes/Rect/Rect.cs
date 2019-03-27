using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public abstract class Rect : IShape
    {
        private readonly Line _data; // flyweight (don't create line per draw)

        public Rect(
            Line data)
        {
            _data = data;
        }

        protected abstract int Hieght { get; }

        public void Display(IOffseter offseter)
        {
            for (int i = 0; i < Hieght; i++)
            {
                _data.Display(offseter);
            }
        }
    }
}
