using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContyext.Domain.Entities
{
    

    public class CreditoCardPayment : Payment
    {
        public CreditoCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber,   DateTime paiDate, 
            DateTime expireDate,
            DateTime total, 
            decimal totalPaid,
            decimal player, 
            Document  document,
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
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumber { get; private set; }


    }

  


}
