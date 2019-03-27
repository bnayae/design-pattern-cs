using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    // null object pattern
    public class NullShape : IShape
    {
        public static readonly IShape Default = new NullShape();
        private NullShape() { }

        public void Display(IOffseter offseter) { /* do nothing */}
    }
}
