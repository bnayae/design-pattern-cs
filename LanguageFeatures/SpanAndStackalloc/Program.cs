using System;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            // stackalloc arrays support initializers
            // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3#stackalloc-arrays-support-initializers
            var arr2 = new int[] { 1, 2, 3 }; // heap allocation

            unsafe
            {
                int* p = stackalloc int[] { 1, 2, 3 }; // stack allocation
                int* pTail = p + 1;
                Console.WriteLine($"Pointer tail start at {*pTail}");
            }

            // https://medium.com/@bnayae/net-span-t-better-performance-29b182b19dce
            Span<int> span = stackalloc[] { 1, 2, 3 };// stack allocation
            Span<int> spanTail = span.Slice(1);
            Console.WriteLine($"Span tail {string.Join(',', spanTail.ToArray())}");
            
            (int, int)[] arr = { (2, 2), (10, 40), (40, 10) };
            var polygon = new Polygon(arr.AsSpan());
            var polygonTail = Tail(polygon); // sent by ref because 'Polygon' is [readonly ref]
            Console.WriteLine($"Polygon tail {string.Join(',', polygonTail.Border.ToArray())}");

            Console.ReadKey();
        }

        private static Polygon Tail(Polygon polygon)
        {
            var p = new Polygon(polygon.Border.Slice(1));
            return p;
        }

    }
}
