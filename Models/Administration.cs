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

    public void UpdateDriverLicenseCategory()
    {
        Console.WriteLine("Enter the identification number of the driver you want to update: ");

        string identificationNumber = Console.ReadLine();

        Driver driver = Drivers.Find(x => x.GetIdentificationNumber() == identificationNumber);

        if (driver != null)
        {
            Console.WriteLine("Driver found");
            driver.ShowDriverDetails();
            Console.WriteLine("Enter the new license category: ");
            Console.WriteLine("1. A2  (motorbike) \n2. B1  (car) \n3. C1  (truck) \n4. C2  (bus) \n5. C3  (other)");
            string licenseCategory = Console.ReadLine();
            driver.UpdateLicenseCategory(licenseCategory);
            Console.WriteLine("License category updated");
        }
        else
        {
            Console.WriteLine("Driver not found");
        }
    }

    public void AddDriverExperience()
    {
        Console.WriteLine("Enter the identification number of the driver you want to update: ");

        string identificationNumber = Console.ReadLine();

        Driver driver = Drivers.Find(x => x.GetIdentificationNumber() == identificationNumber);

        if (driver != null)
        {
            Console.WriteLine("Driver found");
            driver.ShowDriverDetails();
            Console.WriteLine("Enter the years of experience: ");
            int years = Convert.ToInt32(Console.ReadLine());
            driver.AddExperience(years);
            Console.WriteLine("Experience added");
        }
        else
        {
            Console.WriteLine("Driver not found");
        }
    }

    public void ShowAllDrivers()
    {
        foreach (Driver driver in Drivers)
        {
            driver.ShowDriverDetails();
        }
    }

    // methods for Customers
    public void AddCustomer(Customer newCustomer)
    {
        Customers.Add(newCustomer);
    }

    public void DeleteCustomer()
    {
        Console.WriteLine("Enter the identification number of the customer you want to delete: ");

        string identificationNumber = Console.ReadLine();

        Customer customer = Customers.Find(x => x.GetIdentificationNumber() == identificationNumber);

        if (customer != null)
        {
            Console.WriteLine("Customer found");
            customer.ShowCustomerDetails();
            Console.WriteLine("Are you sure you want to delete it? (y/n)");

            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Customers.Remove(customer);
                Console.WriteLine("Customer deleted");
            }
            else
            {
                Console.WriteLine("Customer not deleted");
            }
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }

}
