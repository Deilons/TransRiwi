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

    public void UpdateMembershipLevel(string NewMembershipLevel)
    {
        MembershipLevel = NewMembershipLevel;
    }
}
