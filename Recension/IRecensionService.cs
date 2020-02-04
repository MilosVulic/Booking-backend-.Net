using System.Collections.Generic;
using Booking.Comments;

namespace Booking.Recension
{
    public interface IRecensionService
    {
        List<Recension> GetRecensionsForAccommodation(string accommodationId);

        List<Recension> GetAllRecensions();

        void InsertRecension(Recension recension);
    }
}