using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
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
