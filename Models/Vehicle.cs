using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Vehicle
{
    // properties

    public int Id { get; set; }

    public string Plate { get; set; }

    public string TypeOfVehicle { get; set; }

    public string EngineNumber { get; set; }

    public string SerialNumber { get; set; }

    public byte Capacity { get; set; }

    public Driver Owner { get; set; }


    // methods

    public Vehicle(string plate, string typeOfVehicle, string engineNumber, string serialNumber, byte capacity, Driver owner)
    {
        Plate = plate;
        TypeOfVehicle = typeOfVehicle;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        Capacity = capacity;
        Owner = owner;
    }

    // methods

    public void DeleteVehicle(int id)
    {
        Id = id;
    }
}
