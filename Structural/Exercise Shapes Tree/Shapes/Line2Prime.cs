using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
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
