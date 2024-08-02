using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Administration
{
    // colecctions for users, vehicles, drivers and customers
    public List<Driver> Drivers { get; set; } = new List<Driver>();

    public List<Customer> Customers { get; set; } = new List<Customer>();

    public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    // methods for Drivers

    public void AddDriver(Driver newDriver)
    {
        Drivers.Add(newDriver);
    }

    //
    public void DeleteDriver()
    {
        Console.WriteLine("Enter the identification number of the driver you want to delete: ");

        string identificationNumber = Console.ReadLine();

        Driver driver = Drivers.Find(x => x.GetIdentificationNumber() == identificationNumber);

        if (driver != null)
        {
            Console.WriteLine("Driver found");
            driver.ShowDriverDetails();
            Console.WriteLine("Are you sure you want to delete it? (y/n)");

            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Drivers.Remove(driver);
                Console.WriteLine("Driver deleted");
            }
            else
            {
                Console.WriteLine("Driver not deleted");
            }
        }
        else
        {
            Console.WriteLine("Driver not found");
        }
    }
}
