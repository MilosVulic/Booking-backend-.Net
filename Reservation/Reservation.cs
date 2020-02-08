using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Reservation
{
    public class Reservation
    {
        [BsonId] public string Id { get; set; }

        public string AccommodationId { get; set; }
        
        public string UserId { get; set; }

        public double PriceOverall { get; set; }
        
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }
        
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime EndDate { get; set; }
    }
}