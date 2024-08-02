using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Driver : User
{
    // properties

    public string LicenseNumber { get; set; }

    public string LicenseCategory { get; set; }

    public int DrivingExperience { get; set; }

    // constructor

    public Driver(string name, string lastName, string typeOfDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adress, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeOfDocument, identificationNumber, birthDate, email, phoneNumber, adress)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }

    // methods

    public void UpdateLicenseCategory(string NewlicenseCategory)
    {
        LicenseCategory = NewlicenseCategory;
    }

    public void AddExperience( int Years)
    {
        DrivingExperience += Years;
    }

}
