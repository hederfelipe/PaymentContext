using Flunt.Validations;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObjects
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
            .Requires()
            .IsTrue(Validate(), "Document.Number", "Documento invalido")
            );
        }

        public string Number{ get; private set;}
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            //SO PARA FINS DE TESTE
            if(Type == EDocumentType.CNPJ && Number.Length == 14)
            return true;

            if(Type == EDocumentType.CNPJ && Number.Length == 11)
            return true;
            
            return false;
            //  A regra ainda vai ser emprementada validação de CPF E CNPJ
           
        }
    }
}