using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Exercise
{
    public class BlurSetting : IBlurSetting
    {
        public float Sigma => 7;
    }
}
