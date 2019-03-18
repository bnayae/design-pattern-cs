using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Person
    {
        // either should initialized or use string?
        public string FirstName { get; set; }// = string.Empty;
        public string[]? MiddleNames { get; set; } // = Array.Empty<string>();
        public string LastName { get; set; } //= string.Empty;
    }
}
