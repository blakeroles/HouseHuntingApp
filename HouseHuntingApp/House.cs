using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHuntingApp
{
    class House
    {
        // Attributes
        private string type;
        private double price;
        private string location;
        private int postcode;
        private int bedrooms;
        private int bathrooms;
        private int carSpaces;

        // Constructor
        public House()
        {
            type = "unknown";
            price = 99999999.99;
            location = "unknown";
            postcode = 9999;
            bedrooms = 99;
            bathrooms = 99;
            carSpaces = 99;
        }

        public string getLocation()
        {
            return this.location;
        }
    }
}
