using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]
public class CreateBoletoSubscriptionCommandTests
{
    // Red, Green, Refactor

    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInvalid()
    {
        var command = new CreateBoletoSubscriptionCommand
        {
            FirstName = ""
        };

        command.Validate();
        Assert.AreEqual(false, command.IsValid);
    }
}