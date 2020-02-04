using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Accommodation
{
    public class Accommodation
    {
        [BsonId] public string Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public List<string> ListUrlPics { get; set; }

        public string UserId { get; set; }

        public double AverageRecension { get; set; }
        
        public int NumberOfRecensions { get; set; }
    }
}