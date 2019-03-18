using System;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            RefLocalVariable();

            BasicStackalloc();

            Console.ReadKey();

        }

        #region RefLocalVariable

        private static void RefLocalVariable()
        {
            // ref local variables may be reassigned
            // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3#ref-local-variables-may-be-reassigned
            int i = 10;
            ref int j = ref i;
            j++;
            Console.WriteLine($"i = {i}, j = {j}");
            Console.WriteLine($"\tYet, be careful: ReferenceEquals(i, j) = {ReferenceEquals(i, j)}");
        }

        #endregion // RefLocalVariable


        #region BasicStackalloc

        private static void BasicStackalloc()
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
            Span<int> span = stackalloc [] { 1, 2, 3 };// stack allocation
            Span<int> spanTail = span.Slice(1);
            Console.WriteLine($"Span tail {string.Join(',', spanTail.ToArray())}");
        }

        #endregion // BasicStackalloc

    }
}
