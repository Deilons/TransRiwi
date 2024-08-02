using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Customer : User
{
    // properties

    public string MembershipLevel { get; set; }

    public string PreferredPaymentMethod { get; set; }

    // constructor

    public Customer(string name, string lastName, string typeOfDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adress, string membershiplevel, string preferredpaymentMethod) : base(name, lastName, typeOfDocument, identificationNumber, birthDate, email, phoneNumber, adress)
    {
        MembershipLevel = membershiplevel;
        PreferredPaymentMethod = preferredpaymentMethod;
    }

    // methods

    public static Customer CreateCustomer()
    {
        Guid id = Guid.NewGuid();

        Console.WriteLine("Enter the name of the customer: ");
        string name = Console.ReadLine()?? "";

        Console.WriteLine("Enter the last name of the customer: ");
        string lastName = Console.ReadLine()?? "";
        Console.WriteLine("Enter the type of document of the customer: ");
        string typeOfDocument = Console.ReadLine()?? "";
        Console.WriteLine("Enter the identification number of the customer: ");
        string identificationNumber = Console.ReadLine()?? "";
        Console.WriteLine("Enter the birth date of the customer (dd/mm/yyyy): ");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine()?? "00/00/0000");
        Console.WriteLine("Enter the email of the customer: ");
        string email = Console.ReadLine()?? "";
        Console.WriteLine("Enter the phone number of the customer: ");
        string phoneNumber = Console.ReadLine()?? "";
        Console.WriteLine("Enter the adress of the customer: ");
        string adress = Console.ReadLine()?? "";
        Console.WriteLine("Enter the membership level of the customer: ");
        string membershiplevel = Console.ReadLine()?? "";
        Console.WriteLine("Enter the preferred payment method of the customer: ");
        Console.WriteLine("1. Cash \n2. Credit Card \n3. Debit Card");
        string preferredpaymentMethod = Console.ReadLine()?? "";
        Customer newCustomer = new Customer(name, lastName, typeOfDocument, identificationNumber, birthDate, email, phoneNumber, adress, membershiplevel, preferredpaymentMethod);
        return newCustomer;
    }

    public void ShowCustomerDetails()
    {
        Console.WriteLine($@"
        Id : {Id}
        Name : {Name}
        LastName : {LastName}
        TypeOfDocument : {TypeOfDocument}
        IdentificationNumber : {IdentificationNumber}
        BirthDate : {BirthDate}
        Email : {Email}
        PhoneNumber : {PhoneNumber}
        Adress : {Adress}
        MembershipLevel : {MembershipLevel}
        PreferredPaymentMethod : {PreferredPaymentMethod}
        ");
    }

    public void UpdateMembershipLevel(string NewMembershipLevel)
    {
        MembershipLevel = NewMembershipLevel;
    }
}
