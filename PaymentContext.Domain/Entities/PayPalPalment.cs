using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPalment : Payment
{
    public PayPalPalment(string number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string payer, Document document, Address address, Email email, string transactionCode) : base(number, paidDate,
        expireDate, total, totalPaid, payer, document, address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}