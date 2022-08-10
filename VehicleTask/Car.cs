﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Task
{
    class Car : Vehicle
    {
        public string Brend;
        public string Model;
        public int FuelCapacity;
        public int FuelFor1Km;
       
        public Car(string Brend, string Color, string Model, int Year, int FuelCapacity, int FuelFor1Km)
        {
            this.Brend = Brend;
            this.Color = Color;
            this.Model = Model;
            this.Year = Year;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;          

        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Brend} {Color} {Model} {Year} {FuelCapacity} {FuelFor1Km}  ");
        }
        public int Drive(int way)
        {
          int  CurrentFuel = FuelCapacity - (FuelFor1Km * way);
            return CurrentFuel;
        }
    }
}