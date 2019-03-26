using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
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
