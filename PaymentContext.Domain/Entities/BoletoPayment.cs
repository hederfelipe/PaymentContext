using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContyext.Domain.Entities
{
    
    
    public class BoletoPayment  : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime paiDate, 
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }

        public string BoletoNumber { get; private set; }
        
    }
}
