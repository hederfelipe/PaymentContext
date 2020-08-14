using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObjects
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new Contract()
            .IsEmail(Address, "Email.Address", "Email inválido")
            );
        }

        public string Address{ get; private set;}
       

    }
}