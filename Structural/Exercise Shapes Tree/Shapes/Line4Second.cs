using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
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
