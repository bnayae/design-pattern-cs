using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class Builder : IBuilderABC, IBuilderAB, IBuilderBC, IBuilderAC, 
            IBuilderA, IBuilderB, IBuilderC
    {
        public static readonly IBuilderABC Default = new Builder();

        private readonly string _data;
        private Builder() { }
        private Builder(string data)
        {
            _data = data;
        }


        private Builder A()
        {
            var data = _data + "A";
            return new Builder(data);
        }
        private Builder B()
        {
            var data = _data + "B";
            return new Builder(data);
        }
        private Builder C()
        {
            var data = _data + "C";
            return new Builder(data);
        }

        void IBuilder.Write()
        {
            Console.WriteLine(_data);
        }

        IBuilderBC IBuilderABC.A() => A();
        IBuilderAC IBuilderABC.B() => B();
        IBuilderAB IBuilderABC.C() => C();
        IBuilderB IBuilderAB.A() => A();
        IBuilderA IBuilderAB.B() => B();
        IBuilderC IBuilderBC.B() => B();
        IBuilderB IBuilderBC.C() => C();
        IBuilderC IBuilderAC.A() => A();
        IBuilderA IBuilderAC.C() => C();
        IBuilder IBuilderA.A() => A();
        IBuilder IBuilderB.B() => B();
        IBuilder IBuilderC.C() => C();
    }
}
