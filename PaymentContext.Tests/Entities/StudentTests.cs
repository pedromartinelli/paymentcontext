using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AddSubscription()
    {
        var subscription = new Subscription(null);
        var student = new Student(new Name("Pedro", "Martinelli"), new Document("12345678", EDocumentType.CPF),
            new Email("pedro@email.com"));
        student.AddSubscription(subscription);
    }
}

