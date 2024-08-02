using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class User
{
    //properties
    protected Guid Id { get; set; }

    protected string Name { get; set; }

    protected string LastName { get; set; }

    protected string TypeOfDocument { get; set; }

    protected string IdentificationNumber { get; set; }

    protected DateOnly BirthDate { get; set; }

    protected string Email { get; set; }

    protected string PhoneNumber { get; set; }

    protected string Adress { get; set; }

    //constructor

    protected User(string name, string lastName, string typeOfDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adress)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeOfDocument = typeOfDocument;
        IdentificationNumber = identificationNumber;
        BirthDate = birthDate;
        Email = email;
        PhoneNumber = phoneNumber;
        Adress = adress;
    }

    //methods

    protected void ShowDetails()
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
        ");
    }

    protected int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    protected void ShowAge()
    {
        Console.WriteLine($"Age : {CalculateAge()}");
    }

    // publics methods

    public string GetIdentificationNumber()
    {
        return IdentificationNumber;
    } 

}