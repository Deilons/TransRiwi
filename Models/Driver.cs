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

    public string VehicleType { get; set; }

    // constructor

    public Driver(string name, string lastName, string typeOfDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adress, string licenseNumber, string licenseCategory, int drivingExperience, string vehicleType) : base(name, lastName, typeOfDocument, identificationNumber, birthDate, email, phoneNumber, adress)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
        VehicleType = vehicleType;
    }

    // methods

    public void ShowDriverDetails()
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
        LicenseNumber : {LicenseNumber}
        LicenseCategory : {LicenseCategory}
        DrivingExperience : {DrivingExperience}
        VehicleType : {VehicleType}
        ");
    }

    public static Driver CreateDriver()
    {
        Guid id = Guid.NewGuid();
        Console.WriteLine("Enter the name of the driver: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the last name of the driver: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the type of document of the driver: ");
        string typeOfDocument = Console.ReadLine();
        Console.WriteLine("Enter the identification number of the driver: ");
        string identificationNumber = Console.ReadLine();
        Console.WriteLine("Enter the birth date of the driver (dd/mm/yyyy): ");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter the email of the driver: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the phone number of the driver: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter the adress of the driver: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter the license number of the driver: ");
        string licenseNumber = Console.ReadLine();
        Console.WriteLine("Enter the license category of the driver: ");
        string licenseCategory = Console.ReadLine();
        Console.WriteLine("Enter the driving experience of the driver: ");
        Console.WriteLine("1. A2  (motorbike) \n2. B1  (car) \n3. C1  (truck) \n4. C2  (bus) \n5. C3  (other)");
        int drivingExperience = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the vehicle type of the driver: ");
        Console.WriteLine("1. Car \n2. Motorbike \n3. Truck \n4. Bus \n5. Other");
        string vehicletype = Console.ReadLine();

        Driver newDriver = new Driver(name, lastName, typeOfDocument, identificationNumber, birthDate, email, phoneNumber, adress, licenseNumber, licenseCategory, drivingExperience, vehicletype);

        return newDriver;
    }

    public void UpdateLicenseCategory(string NewlicenseCategory)
    {
        LicenseCategory = NewlicenseCategory;
    }

    public void AddExperience(int Years)
    {
        DrivingExperience += Years;
    }

}
