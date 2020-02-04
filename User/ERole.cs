using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Booking.User
{
    public enum ERole
    {
        Administrator,
        Manager,
        Customer,
        Visitor
    }
}