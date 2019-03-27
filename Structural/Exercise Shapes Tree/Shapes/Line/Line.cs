using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public abstract class Line : IShape
    {
        private readonly string _data; // flyweight (don't create string per draw)

        public Line(
            IDrawingChar drawingChar, 
            int length,
            CharStyle style)
        {
            char c = style switch
            {
                CharStyle.Primary => drawingChar.Primary,
                _ => drawingChar.Secondary
            };

            _data = new string(c, length);
        }


        public void Display(IOffseter offseter)
        {
            offseter.Next();
            Console.WriteLine(_data);
        }
    }
}
