using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Interfaces;

namespace TransRiwi.Models;

public class Administration : IAdmistration
{
    // colecctions for users, vehicles, drivers and customers
    public static List<Driver> Drivers { get; set; } = new List<Driver>();

    public static List<Customer> Customers { get; set; } = new List<Customer>();

    public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

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

    public void UpdateCustomerMembershipLevel()
    {
        Console.WriteLine("Enter the identification number of the customer you want to update: ");

        string identificationNumber = Console.ReadLine();

        Customer customer = Customers.Find(x => x.GetIdentificationNumber() == identificationNumber);

        if (customer != null)

        {
            Console.WriteLine("Customer found");
            customer.ShowCustomerDetails();
            Console.WriteLine("Enter the new membership level: ");
            string membershipLevel = Console.ReadLine();
            customer.UpdateMembershipLevel(membershipLevel);
            Console.WriteLine("Membership level updated");
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }

    public void ShowAllCustomers()
    {
        foreach (Customer customer in Customers)
        {
            customer.ShowCustomerDetails();
        }
    }

    // methods for vehicles

    public void AddVehicle(Vehicle newVehicle)
    {
        Vehicles.Add(newVehicle);
    }

    public void DeleteVehicle()
    {
        Console.WriteLine("Enter the id of the vehicle you want to delete: ");

        int idToDelete = Convert.ToInt32(Console.ReadLine());

        var vehicle = Vehicles.Find(x => x.Id == idToDelete);

        if (vehicle != null)
        {
            Console.WriteLine("Vehicle found");
            vehicle.ShowVehicleDetails();
            Console.WriteLine("Are you sure you want to delete it? (y/n)");

            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Vehicles.Remove(vehicle);
                Console.WriteLine("Vehicle deleted");
            }
            else
            {
                Console.WriteLine("Vehicle not deleted");
            }
        }
        else
        {
            Console.WriteLine("Vehicle not found");
        }
    }

    public void ShowAllVehicles()
    {
        foreach (Vehicle vehicle in Vehicles)
        {
            vehicle.ShowVehicleDetails();
        }
    }

    // filters methods

    public void ListOfUsers30YearsOld()
    {
        foreach (Driver driver in Drivers)
        {
            if (driver.GetAge() > 30)
            {
                driver.ShowDriverDetails();
            }
        }
    }

    public void DrivesByExperienceDescending()
    {
        foreach (Driver driver in Drivers)
        {
            driver.ShowDriverDetails();
        }
    }

    public void CustomerWhoPaidWithCreditCard()
    {
        foreach (Customer customer in Customers)
        {
            if (customer.PreferredPaymentMethod == "Credit Card")
            {
                customer.ShowCustomerDetails();
            }
        }
    }

    public void DriversByLicenseA2()
    {
        foreach (Driver driver in Drivers)
        {
            if (driver.LicenseCategory == "A2")
            {
                driver.ShowDriverDetails();
            }
        }
    }

    // interface methods

    public void MajorMenu()
    {
        Console.Clear();
        Console.WriteLine(
@"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                  Administration                  ║
║                                                  ║
║       1. Driver Management                       ║
║       2. Customer Management                     ║
║       3. Vehicle Management                      ║
║       4. Filters                                 ║
║       5. Exit                                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void MenuDriver()
    {
        Console.Clear();
        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                  Driver Management               ║
║                                                  ║
║       1. Create Driver                           ║
║       2. Update Driver License Category          ║
║       3. Add Driver Experience                   ║
║       4. Show All Drivers                        ║
║       5. Delete Driver                           ║
║       6. Go Back to Main Menu                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void MenuCustomer()
    {
        Console.Clear();
        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                  Customer Management             ║
║                                                  ║
║       1. Create Customer                         ║
║       2. Update Customer Membership Level        ║
║       3. Show All Customers                      ║
║       4. Delete Customer                         ║
║       5. Go Back to Main Menu                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void MenuVehicle()
    {
        Console.Clear();
        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                  Vehicle Management              ║
║                                                  ║
║       1. Create Vehicle                          ║
║       2. Show All Vehicles                       ║
║       3. Delete Vehicle                          ║
║       4. Go Back to Main Menu                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void MenuFilter()
    {
        Console.Clear();
        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                      Filters                     ║
║                                                  ║
║       1. Show All Customers                      ║
║       2. Show All Drivers                        ║
║       3. Drivers older than 30 years             ║
║       4. Drivers by Experience                   ║
║       5. Customer who paid with Credit Card      ║
║       6. All Drivers by License A2               ║
║       7. Go Back to Main Menu                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }
}
