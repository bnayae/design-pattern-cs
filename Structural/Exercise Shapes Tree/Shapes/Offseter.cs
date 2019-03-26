using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class Offseter : IOffseter
    {
        private readonly int _x;
        private readonly int _y;
        private int _currentY;

        public Offseter(int x, int y)
        {
            _x = x;
            _y = _currentY = y;
        }

        public void Next() => Console.SetCursorPosition(_x, _currentY++);

        public void Reset() => _currentY = _y;

        public IOffseter Shift(int x, int y) => new Offseter(_x + x, _y + y);
    }
}
