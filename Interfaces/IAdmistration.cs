using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Interfaces;

public interface IAdmistration
{
    public void menuPrincipal()
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

    public void menuDriver()
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
║       6. Exit                                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void menuCustomer()
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
║       5. Exit                                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void menuVehicle()
    {   
        Console.Clear();
        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                                                  ║
║                  Vehicle Management              ║
║                                                  ║
║       1. Create Vehicle                          ║
║       2. Update Vehicle Type                     ║
║       3. Show All Vehicles                       ║
║       4. Delete Vehicle                          ║
║       5. Exit                                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }

    public void menuFilter()
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
║       7. Exit                                    ║
║                                                  ║
╚══════════════════════════════════════════════════╝

Enter your choice: ");
    }
}
