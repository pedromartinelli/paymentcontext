﻿using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        //AddNotifications(new Contract<Notification>()
        //    .Requires()
        //    .IsGreaterThan(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
        //    .IsLowerThan(FirstName, 40, "Name.FirstName", "Nome deve conter menos que 40 caracteres")
        //    .IsGreaterThan(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
        //    .IsLowerThan(LastName, 40, "Name.LastName", "Sobrenome deve conter menos que 40 caracteres")
        //);
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}