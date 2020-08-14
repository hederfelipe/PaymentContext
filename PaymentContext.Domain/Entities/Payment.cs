using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContyext.Domain.Entities
{
        public abstract class Payment


    {
        public Payment(DateTime paiDate, DateTime expireDate, DateTime total, decimal totalPaid, decimal player, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaiDate = paiDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Player = player;
            Document = document;
            Address = address;
            Email = email;

            
        }

        public string Number { get; private set; }

        public DateTime PaiDate { get; private set; }

        public DateTime ExpireDate { get; private set; }

        public DateTime Total { get; private set; }

        public decimal TotalPaid { get; private set; }

        public decimal Player { get; private set; }

        public Document Document{ get; private set; }

        public Address Address {get; private set;}

        public Email Email { get; private set; }
     }

}
    
   