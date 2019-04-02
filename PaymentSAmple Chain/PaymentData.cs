using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSAmple_Chain
{
    public class PaymentData
    {
        public PaymentData(
            Guid requestId,
            int userId, 
            double amount, 
            PaymentMethod method,
            string location)
        {
            RequestId = requestId;
            UserId = userId;
            Amount = amount;
            Method = method;
            Location = location;
        }

        public Guid RequestId { get; }
        public int UserId { get; }
        public double Amount { get; }
        public PaymentMethod Method { get; }
        public string Location { get; }
    }
}
