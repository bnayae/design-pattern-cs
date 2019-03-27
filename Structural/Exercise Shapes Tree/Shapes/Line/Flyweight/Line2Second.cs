using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Line2Second : Line
    {
        public Line2Second(
            IDrawingChar drawingChar)
                :base (drawingChar, 2, CharStyle.Secondary)
        {
        }
    }
}
