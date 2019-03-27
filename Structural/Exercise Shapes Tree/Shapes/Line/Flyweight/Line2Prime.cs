using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Line2Prime : Line
    {
        public Line2Prime(
            IDrawingChar drawingChar)
                :base (drawingChar, 2, CharStyle.Primary)
        {
        }
    }
}
