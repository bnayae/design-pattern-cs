using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace PaymentSAmple_Chain
{
    public class CreditHandler : ChainBase
    {
        public CreditHandler(
            IImmutableList<(Predicate<PaymentData> Cond, IHandler Handler)> handlers, 
            IImmutableList<IValidation> validations) : base(handlers, validations)
        {
        }

     
    }
}
