using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Recension
{
    public class Recension
    {
        [BsonId] public string Id { get; set; }
        
        public string UserId { get; set; }
        
        public double NumberOfStars { get; set; }
        
        public string AccommodationId { get; set; }
    }
}