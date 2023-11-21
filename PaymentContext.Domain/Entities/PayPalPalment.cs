using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPalment : Payment
{
    public PayPalPalment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string payer, Document document, Address address, Email email) : base(paidDate,
        expireDate, total, totalPaid, payer, document, address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}