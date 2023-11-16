//using PaymentContext.Domain.Entities;
//using PaymentContext.Domain.Enums;
//using PaymentContext.Domain.ValueObjects;

//namespace PaymentContext.Tests.Entities;

//[TestClass]
//public class StudentTests
//{
//    [TestMethod]
//    public void ShouldReturnErrorWhenHadActiveSubscription()
//    {
//        var name = new Name("Pedro", "Martinelli");
//        var document = new Document("12345678912", EDocumentType.CPF);
//        var email = new Email("pedro@email.com");

//        var student = new Student(name, document, email);
//        var subscription = new Subscription(DateTime.Now.AddDays(30));

//        student.AddSubscription(subscription);

//        Assert.IsTrue(subscription.IsValid);
//    }

//    [TestMethod]
//    public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
//    {
//        var name = new Name("Pedro", "Martinelli");
//        var document = new Document("12345678912", EDocumentType.CPF);
//        var email = new Email("pedro@email.com");

//        var student = new Student(name, document, email);
//        var subscription = new Subscription(DateTime.Now.AddDays(30));

//        student.AddSubscription(subscription);

//        Assert.IsTrue(subscription.IsValid);
//    }

//    [TestMethod]
//    public void ShouldReturnSuccessWhenHadnoActiveSubscription()
//    {
//        var name = new Name("Pedro", "Martinelli");
//        var document = new Document("12345678912", EDocumentType.CPF);
//        var email = new Email("pedro@email.com");

//        var student = new Student(name, document, email);
//        var subscription = new Subscription(DateTime.Now.AddDays(30));

//        student.AddSubscription(subscription);

//        Assert.IsTrue(!subscription.IsValid);
//    }
//}