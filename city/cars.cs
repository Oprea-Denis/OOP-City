using System;
using System.Collections.Generic;
using System.Text;

namespace city
{
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
         public int Year { get; set; }
        public string Plate { get; set; }
 
        public Cars(string brand, string model, int year, string plate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Plate = plate;
        }
    }
}