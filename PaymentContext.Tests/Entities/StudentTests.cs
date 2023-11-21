using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PaymentContext.Tests.Entities;

[TestClass]
[Ignore]
public class StudentTests
{
    private readonly Name _name;
    private readonly Email _email;
    private readonly Document _document;
    private readonly Address _address;
    private readonly Student _student;
    private readonly Subscription _subscription;
    private readonly Payment _payment;

    public StudentTests()
    {
        _name = new Name("Pedro", "Martinelli");
        _document = new Document("12345678912", EDocumentType.CPF);
        _email = new Email("pedro@email.com");
        _address = new Address("Rua 1", "201", "Bairro 1", "Cidade 1", "Estado 1", "País 1", "12345678");
        _student = new Student(_name, _document, _email);
        _subscription = new Subscription(null);
        _payment = new PayPalPalment("12345678", DateTime.Now, DateTime.Now.AddDays(30), 10, 10, "payer", _document, _address, _email);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenHadActiveSubscription()
    {
        _subscription.AddPayment(_payment);
        _student.AddSubscription(_subscription);
        _student.AddSubscription(_subscription);

        Assert.IsFalse(_student.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenHadnoActiveSubscription()
    {
        _subscription.AddPayment(_payment);
        _student.AddSubscription(_subscription);

        Assert.IsTrue(_student.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
    {
        _student.AddSubscription(_subscription);

        Assert.IsFalse(_student.IsValid);
    }
}