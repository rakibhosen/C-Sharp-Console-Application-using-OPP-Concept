using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_22_Work_01.Models
{
    public sealed class Car:Vehicle, IInteriorFeature
    {
        public  Car() {  }
        public Car(string model, int make, int cc, int gearNo, VehicleType type, int wheels,int seatNum,int doorNum):base(model, make, cc, gearNo, type)
        {
            this.Wheels = wheels;
            this.DoorNo = doorNum;
            this.SeatNo = seatNum;
        }
        public int Wheels { get; set; }
        public int SeatNo { get; set; }
        public int DoorNo { get; set; }
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
