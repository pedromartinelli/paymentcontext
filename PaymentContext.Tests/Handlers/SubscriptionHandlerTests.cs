using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers;

[TestClass]
[Ignore]
public class SubscriptionHandlerTests
{
    // Red, Green, Refactor

    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());

        var command = new CreateBoletoSubscriptionCommand
        {
            FirstName = "Pedro",
            LastName = "Martinelli",
            Document = "12345678911",
            Email = "pedro@email.com",

            BarCode = "12321415661213",
            BoletoNumber = "123124125152",
            PaymentNumber = "12214122144",
            PaidDate = DateTime.Now,
            ExpireDate = DateTime.Now.AddMonths(1),
            Total = 60,
            TotalPaid = 60,
            Payer = "payer",
            PayerDocument = "12345678911",
            PayerDocumentType = EDocumentType.CPF,
            PayerEmail = "payer@payer.com",

            Street = "rua1",
            HouseNumber = "123",
            Neighborhood = "bairro",
            City = "cidade",
            State = "estado",
            Country = "país",
            ZipCode = "5645456",
        };

        handler.Handle(command);
        Assert.AreEqual(false, handler.IsValid);

    }

    [TestMethod]
    public void ShouldReturnErrorWhenEmailExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());

        var command = new CreateBoletoSubscriptionCommand
        {
            FirstName = "Pedro",
            LastName = "Martinelli",
            Document = "12345678912",
            Email = "existe@email.com",

            BarCode = "12321415661213",
            BoletoNumber = "123124125152",
            PaymentNumber = "12214122144",
            PaidDate = DateTime.Now,
            ExpireDate = DateTime.Now.AddMonths(1),
            Total = 60,
            TotalPaid = 60,
            Payer = "payer",
            PayerDocument = "12345678911",
            PayerDocumentType = EDocumentType.CPF,
            PayerEmail = "payer@payer.com",

            Street = "rua1",
            HouseNumber = "123",
            Neighborhood = "bairro",
            City = "cidade",
            State = "estado",
            Country = "país",
            ZipCode = "5645456",
        };

        handler.Handle(command);
        Assert.AreEqual(false, handler.IsValid);

    }
}
