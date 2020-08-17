using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entites;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        
        private IList<Subscription>_subscriptions;

    
        public Student( Name name , Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;

            _subscriptions = new List<Subscription>();

            
            AddNotifications(name, document, email);

        }
        public  Name Name { get; private set; }

        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public Address Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get {return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription){
            var hasSubscriptionsActive = false;
            foreach(var sub in _subscriptions)
            {
                if(sub.Active)
                hasSubscriptionsActive=true;
            }

            AddNotifications(new Contract().Requires()
            .IsFalse(hasSubscriptionsActive,"Student.Subsciptions", "Você ja tem uma assinatura ativa")
            .AreEquals(0,subscription.Payments.Count,"Student.Subscription.Payments","Esta assinatura não possui pagamentos")
            );
            // uma das alternativas a ser usada 
        //   if(hasSubscriptionsActive)
        //   AddNotification("Student.Subscriptions", "você ja tem uma assinatura ativa");

        }
    }
}