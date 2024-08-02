using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Vehicle
{
    // properties
    public static int IdCounter { get; set; }=0;

    public  int Id { get;  set; }

    public string Plate { get; set; }

    public string TypeOfVehicle { get; set; }

    public string EngineNumber { get; set; }

    public string SerialNumber { get; set; }

    public byte Capacity { get; set; }
    
    public List<Driver> Drivers = new List<Driver>();

    public static Driver Owner { get; set; }

    public string OwnerIdentificationNumber { get; set; }


    // methods

    public Vehicle(string plate, string typeOfVehicle, string engineNumber, string serialNumber, byte capacity, Driver owner)
    {   
        Id = 0;
        Plate = plate;
        TypeOfVehicle = typeOfVehicle;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        Capacity = capacity;
        Owner = owner;
    }

    // methods

    public static Vehicle CreateVehicle()
    {

        Console.WriteLine("Enter the plate of the vehicle: ");
        string plate = Console.ReadLine();

        Console.WriteLine("Enter the type of vehicle: ");
        string typeOfVehicle = Console.ReadLine();

        Console.WriteLine("Enter the engine number of the vehicle: ");
        string engineNumber = Console.ReadLine();

        Console.WriteLine("Enter the serial number of the vehicle: ");
        string serialNumber = Console.ReadLine();

        Console.WriteLine("Enter the capacity of the vehicle: ");
        byte capacity = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter the identification number of the owner of the vehicle: ");
        string OwnerIdentificationNumber = Console.ReadLine();

        var owner = Administration.Drivers.Find(x => x.GetIdentificationNumber() == OwnerIdentificationNumber);

        Vehicle newVehicle = new Vehicle(plate, typeOfVehicle, engineNumber, serialNumber, capacity, owner);
        return newVehicle;
    }

    public void DeleteVehicle(int id)
    {
        if (Id == id)
        {
            Console.WriteLine("Vehicle deleted");
        }
        else
        {
            Console.WriteLine("Vehicle not deleted");
        }
    }

    public void ShowVehicleDetails()
    {
        Console.WriteLine($@"
        Id : {Id}
        Plate : {Plate}
        TypeOfVehicle : {TypeOfVehicle}
        EngineNumber : {EngineNumber}
        SerialNumber : {SerialNumber}
        Capacity : {Capacity}
        ");
    }
}
