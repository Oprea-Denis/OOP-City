using System;
using System.Collections.Generic;
using System.Text;

namespace city
{
    class Streets
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public Streets(string streetName, int streetNumber)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
        }
    }
}