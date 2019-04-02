using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class ShapeDecorator : IShape
    {
        private readonly IShape _inner;

        public ShapeDecorator(IShape inner)
        {
            _inner = inner;
        }
        public void Display(IOffseter offseter)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            _inner.Display(offseter);

            Console.ResetColor();
        }
    }
}
