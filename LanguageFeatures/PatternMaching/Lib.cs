using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#more-patterns-in-more-places

namespace Bnaya.Samples
{

    public class Lib
    {
        #region CalcArea - by type

        // C# 6
        public int CalcArea(IShape value)
        {
            int area = 0;

            switch (value)
            {
                case IRect rect:
                    area = rect.Width * rect.Height;
                    break;
                case ITriangle triangle:
                    area = triangle.Base * triangle.Height / 2;
                    break;
            }

            return area;
        }

     
        // C# 8
        public int CalcArea8(IShape value)
        {
            var area = value switch
            {
                IRect rect => rect.Width * rect.Height,
                ITriangle triangle => triangle.Base * triangle.Height / 2,
                _ => throw new NotSupportedException()
            };

            return area;
        }

        #endregion // CalcArea - by type

        #region GetTaxFactor

        public decimal GetTaxFactor(IAddress location)
        {
            return location switch
                    {
                        { Country: "ISR" } => 0.17M,
                        { Country: "US" } => location switch
                        { 
                            { State: "WA" } => 0.06M,
                            { State: "MN" } => 0.75M,
                            { State: "MI" } => 0.05M,
                            // ...
                            _ => 0M
                        },
                        // ...
                        _ => throw new NotSupportedException()
                    };
        }

        #endregion // GetTaxFactor

        #region Calc

        public double Calc((Operation operation, int x, int y) data)
        {
            return data switch
            {
                // use Deconstruct
                (Operation.Add, int x, int y) => x + y,
                (Operation.Mult, int x, int y) => x * y,
                (Operation.Sub, int x, int y) => x - y,
                (Operation.Div, int x, int y) => x / y,
                (_, 0, int y) => y, // ignore that it seem stupid, focus on the abilities
                (_, int x, 0) => x, // ignore that it seem stupid, focus on the abilities
                _ => throw new NotSupportedException()
            };
        }

        #endregion // Calc

        #region GetQuadrant

        public string GetQuadrant((int x, int y) point) 
        {
            return point switch 
            {
                (0, 0) => "origin",
                (int x, int y) when x > 0 && y > 0 => "Quadrant 1",
                (int x, int y) when x < 0 && y > 0 => "Quadrant 2",
                (int x, int y) when x < 0 && y < 0 => "Quadrant 3",
                (int x, int y) when x > 0 && y < 0 => "Quadrant 4",
                _ => "unknown"
            };
        }

        #endregion // GetQuadrant
    }
}
