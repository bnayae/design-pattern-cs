using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public abstract class Rect : IShape
    {
        private readonly IShape _data; // flyweight (don't create line per draw)

        public Rect(
            IShape data)
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
