using OL04_M3_Class_22_Work_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_22_Work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car information input");
            Car c = new Car();
            Console.Write("Model: ");
            c.Model = Console.ReadLine();
            Console.Write("Make: ");
            c.Make = int.Parse(Console.ReadLine());
            Console.Write("CC: ");
            c.CC = int.Parse(Console.ReadLine());
            Console.Write("Gear No: ");
            c.GearNo = int.Parse(Console.ReadLine());


            Console.Write("Seat No: ");
            c.SeatNo = int.Parse(Console.ReadLine());
            Console.Write("Door No: ");
            c.DoorNo = int.Parse(Console.ReadLine());
            Console.Write("Type: [NormalCar,RacingCar, FamilyCar]");
            c.Type = (VehicleType)Enum.Parse(typeof(VehicleType), Console.ReadLine());
            Console.Write("Wheels: ");
            c.Wheels = int.Parse( Console.ReadLine());
            Console.Write("Faeture: ");
            string input = Console.ReadLine();
            c.AddFeature(input.Split(','));


            Console.WriteLine("Bike information input");
            Console.WriteLine();
           Bike b= new Bike();
            Console.Write("Model: ");
            b.Model = Console.ReadLine();
            Console.Write("Make: ");
            b.Make = int.Parse(Console.ReadLine());
            Console.Write("CC: ");
            b.CC = int.Parse(Console.ReadLine());
            Console.Write("Gear No: ");
            b.GearNo = int.Parse(Console.ReadLine());
            Console.Write("Mileage : ");
            b.Mileage = Console.ReadLine();

            Console.Write("BHP : ");
            b.BHP = Console.ReadLine();

            Console.Write("Torque : ");
            b.Torque = Console.ReadLine();

            Console.Write("Front Brake : ");
            b.FrontBreak = Console.ReadLine();

            Console.Write("Rear Brake : ");
            b.RearBrake = Console.ReadLine();

            Console.Write("Start Type : ");
            b.StartType = Console.ReadLine();



            Console.Write("Type: [NormalBike,RacingBike, FamilyBike]");
            b.Type = (VehicleType)Enum.Parse(typeof(VehicleType), Console.ReadLine());
            Console.Write("Wheels: ");
            c.Wheels = int.Parse(Console.ReadLine());
            Console.Write("Faeture: ");
            string input1 = Console.ReadLine();
            b.AddFeature(input1.Split(','));


            Console.WriteLine();
            Console.WriteLine("Car information : ");
            Console.WriteLine(c);
            Console.WriteLine($"Seat No :{c.DoorNo}");
            Console.WriteLine($"Door No: {c.SeatNo}");
            Console.WriteLine();
            Console.WriteLine("Bike information : ");
            Console.WriteLine(b);
            Console.WriteLine($"Power in BHP :{b.BHP}");
            Console.WriteLine($"Torque in NM :{b.Torque}");
            Console.WriteLine($"Front Brake :{b.FrontBreak}");
            Console.WriteLine($"Rear Brake :{b.RearBrake}");
            Console.WriteLine($"Mileage Per Litre :{b.Mileage}");
            Console.WriteLine($"Start Type :{b.StartType}");
            Console.ReadLine();
        }
    }
}
