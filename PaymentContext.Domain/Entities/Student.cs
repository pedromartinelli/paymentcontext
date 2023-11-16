using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private readonly IList<Subscription> _subscriptions;

    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();

        AddNotifications(name, document, email);
    }

    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();

    public void AddSubscription(Subscription subscription)
    {
        var hasActiveSubscription = false;
        foreach (var sub in _subscriptions)
        {
            if (sub.Active) hasActiveSubscription = true;
        }

        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsFalse(hasActiveSubscription, "Student.Subscription", "Você já possui uma assinatura ativa")
            .IsGreaterThan(subscription.Payments.Count, 0, "Subscription.Payments", "Esta assinatura não possui pagamentos")
        );

        if (hasActiveSubscription)
            AddNotification("Student.Subscription", "Você já possui uma assinatura ativa.");

        _subscriptions.Add(subscription);
    }
}