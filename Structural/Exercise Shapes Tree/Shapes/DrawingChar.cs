using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    // null object pattern
    public class DrawingChar : IDrawingChar
    {
        public DrawingChar(char primary, char secondary)
        {
            Primary = primary;
            Secondary = secondary;
        }

        public char Primary { get; }
        public char Secondary { get; }
    }
}
