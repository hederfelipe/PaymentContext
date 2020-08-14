using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContyext.Domain.Entities
{
       
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
            DateTime paiDate, 
            DateTime expireDate,
            DateTime total, 
            decimal totalPaid,
            decimal player, 
            Document document,
            Address address, 
            Email email) : base (paiDate, 
            expireDate, 
            total,  
            totalPaid, 
            player, 
            document, 
            address,
            email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }


}
