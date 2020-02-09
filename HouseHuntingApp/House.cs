using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace HouseHuntingApp
{
    [Table( Name = "dbo.Houses")]
    class House
    {
        // Attributes
        [Column(IsPrimaryKey = true)]
        private int HouseID { get; set; }

        [Column] public string type { get; set; }
        [Column] public double price { get; set; }
        [Column] public string location { get; set; }
        [Column] public int postcode { get; set; }
        [Column] public int bedrooms { get; set; }
        [Column] public int bathrooms { get; set; }
        [Column] public int carSpaces { get; set; }
        [Column] public double latitude { get; set; }
        [Column] public double longitude { get; set; }
        [Column] public int priceRating { get; set; }
        [Column] public int houseRating { get; set; }
        [Column] public int safetyRating { get; set; }
        [Column] public int transportRating { get; set; }
        [Column] public int locationRating { get; set; }
        [Column] public int potentialRating { get; set; }
        [Column] public int totalRating { get; set; }
        [Column] public double distanceFromTeganWork { get; set; }
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


    }
}
