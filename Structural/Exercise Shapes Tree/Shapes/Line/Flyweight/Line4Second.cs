using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Line4Second : Line
    {
        public Line4Second(
            IDrawingChar drawingChar)
                :base (drawingChar, 4, CharStyle.Secondary)
        {
        }
    }
}
