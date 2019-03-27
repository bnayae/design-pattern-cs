using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Line4Prime : Line
    {
        public Line4Prime(
            IDrawingChar drawingChar)
                :base (drawingChar, 4, CharStyle.Primary)
        {
        }
    }
}
