using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_22_Work_01.Models
{
    public sealed class Bike:Vehicle, IExteriorFeature
    {
        public Bike() { }
        public Bike(string bhp,string torque,string mileage, string FrontBreak,string rearbrake, string model, int make, int cc, int gearNo, VehicleType type, string startType) : base(model, make, cc, gearNo, type)
        {
            this.StartType = startType;
            this.BHP = bhp;
            this.Torque = torque;
            this.Mileage = mileage;
            this.FrontBreak = FrontBreak;
            this.RearBrake = rearbrake;
        }
        public string StartType { get; set; }
        public string BHP { get; set; }
        public string Torque { get; set; }
        public string Mileage { get; set; }
        public string FrontBreak { get; set; }
        public string RearBrake { get; set; }

        private string[] Feature { get; set; }
        public void AddFeature(string[] feature)
        {
            this.Feature = feature;
        }

        public string GetFeature()
        {
            return string.Join(",", this.Feature);
        }
        public override string ToString()
        {
            return base.ToString()
                + "\n" +
                $"Feature: {GetFeature()}";
        }
    }
}
