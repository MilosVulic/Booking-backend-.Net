using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Apartment
{
    public class Apartment
    {
        [BsonId] public string Id { get; set; }

        public int BedNumber { get; set; }

        public bool AirCondition { get; set; }

        public bool Tv { get; set; }

        public bool Wifi { get; set; }
        
        public string SquareFootage { get; set; }
        
        public double PricePerNight { get; set; }
        
        public List<string> ListUrlPics { get; set; }
        
        public string AccommodationId { get; set; } 
    }
}