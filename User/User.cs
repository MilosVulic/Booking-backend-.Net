using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Booking.User
{
    public class User
    {
        [BsonId] public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public long IdCardNumber { get; set; }

        public long AccountNumber { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public ERole Role { get; set; }

        public string UrlPic { get; set; }
        
        public string Token { get; set; }
    }
}