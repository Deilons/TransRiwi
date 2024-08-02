using System.Security.Cryptography.X509Certificates;
using TransRiwi.Models;
Administration administration = new();

bool isRunning = true;

while (isRunning)
{   

    Console.Clear();

    administration.MajorMenu();

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            administration.MenuDriver();
            string driverChoice = Console.ReadLine();
            switch (driverChoice)
            {
                case "1":
                    Console.Clear();
                    var driver = Driver.CreateDriver();
                    administration.AddDriver(driver);
                    Continue();
                    break;
                case "2":
                Console.Clear();
                    administration.UpdateDriverLicenseCategory();
                    Continue();
                    break;
                case "3":
                Console.Clear();
                    administration.AddDriverExperience();
                    Continue();
                    break;
                case "4":
                Console.Clear();
                    administration.ShowAllDrivers();
                    Continue();
                    break;
                case "5":
                Console.Clear();
                    administration.DeleteDriver();
                    Continue();
                    break;
                case "6":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            break;
        case "2":
            administration.MenuCustomer();
            string customerChoice = Console.ReadLine();
            switch (customerChoice)
            {
                case "1":
                    Console.Clear();
                    var customer = Customer.CreateCustomer();
                    administration.AddCustomer(customer);
                    Continue();
                    break;
                case "2":
                Console.Clear();
                    administration.UpdateCustomerMembershipLevel();
                    Continue();
                    break;
                case "3":
                Console.Clear();
                    administration.ShowAllCustomers();
                    Continue();
                    break;
                case "4":
                Console.Clear();
                    administration.DeleteCustomer();
                    Continue();
                    break;
                case "5":
                Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            break;
        case "3":
            administration.MenuVehicle();
            string vehicleChoice = Console.ReadLine();
            switch (vehicleChoice)
            {
                case "1":
                    Console.Clear();
                    var vehicle = Vehicle.CreateVehicle();
                    administration.AddVehicle(vehicle);
                    Continue();
                    break;
                case "2":
                Console.Clear();
                    administration.ShowAllVehicles();
                    Continue();
                    break;
                case "3":
                Console.Clear();
                    administration.DeleteVehicle();
                    Continue();
                    break;
                case "4":
                Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            break;
        case "4":
            administration.MenuFilter();
            string filterChoice = Console.ReadLine();
            switch (filterChoice)
            {
                case "1":
                Console.Clear();
                administration.ShowAllCustomers();
                Continue();
                    break;
                case "2":
                Console.Clear();
                administration.ShowAllDrivers();
                Continue();
                    break;
                case "3":
                Console.Clear();
                administration.ListOfUsers30YearsOld();
                Continue();
                    break;
                case "4":
                Console.Clear();
                administration.DrivesByExperienceDescending();
                Continue();
                    break;
                case "5":
                Console.Clear();
                administration.CustomerWhoPaidWithCreditCard();
                Continue();
                    break;
                case "6":
                Console.Clear();
                administration.DriversByLicenseA2();
                Continue();
                    break;
                case "7":
                Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            break;
        case "5":
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
void Continue()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}