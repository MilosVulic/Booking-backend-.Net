using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Comments
{
    public class Comment
    {
        [BsonId] public string Id { get; set; }
        
        public string Content { get; set; }
        
        public string UserId { get; set; }
        
        public string AccommodationId { get; set; }
        
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }
    }
}