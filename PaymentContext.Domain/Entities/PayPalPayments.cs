using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContyext.Domain.Entities
{
       
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
            DateTime paiDate, 
            DateTime expireDate,
            decimal total, 
            decimal totalPaid,
            string payer, 
            Document document,
            Address address, 
            Email email) : base (paiDate, 
            expireDate, 
            total,  
            totalPaid, 
            payer, 
            document, 
            address,
            email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }


}
