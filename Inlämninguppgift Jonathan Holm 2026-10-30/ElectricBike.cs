using System;
using System.Collections.Generic;
using System.Text;

namespace Rentals
{
    internal class ElectricBike : Bike
    {
        public override string Type { get; set; } = "ElectricBike";
        public int Battery { get; set; } = 100;
        public virtual void Display()
        {
            Console.WriteLine($"""
            {Index}   {Type}    {Availability} {Battery}
            """);
        }
    }
}