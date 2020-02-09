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
        private double latitude;
        private double longitude;
        private int priceRating;
        private int houseRating;
        private int safetyRating;
        private int transportRating;
        private int locationRating;
        private int potentialRating;
        private int totalRating;
        private double distanceFromTeganWork;

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
            latitude = 99.9;
            longitude = 99.9;
            priceRating = 99;
            houseRating = 99;
            safetyRating = 99;
            transportRating = 99;
            locationRating = 99;
            potentialRating = 99;
            totalRating = 999;
            distanceFromTeganWork = 999.99;
        }

        public string getLocation()
        {
            return this.location;
        }
    }
}
