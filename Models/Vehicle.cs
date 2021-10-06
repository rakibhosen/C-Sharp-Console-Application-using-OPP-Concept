using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_22_Work_01.Models
{
    public abstract class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string model, int make, int cc, int gearNo, VehicleType type)
        {
            this.Model = model;this.Make = make;this.CC = cc;this.GearNo = gearNo;this.Type = type;
        }
        public string Model { get; set; }
        public int Make { get; set; }
        public int CC { get; set; }
        public int GearNo { get; set; }
        public VehicleType Type { get; set; }
        public override string ToString()
        {
            return $"ModeL: {this.Model}\nMake: {this.Make}\nCC: {CC}\nType: {this.Type}\n" +
                $"Gear Type: {GearNo}";
        }
    }
}
