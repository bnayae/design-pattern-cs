using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSAmple_Chain
{
    public class CreditValidation : IValidation
    {
        public bool Validate(PaymentData data)
        {
            return true;
        }
    }
}
