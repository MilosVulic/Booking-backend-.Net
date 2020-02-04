using System.Collections.Generic;

namespace Booking.Accommodation
{
    public interface IAccommodationService
    {
        List<Accommodation> GetAllAccommodations();
        Accommodation GetAccommodation(string id);
        Accommodation InsertAccommodation(Accommodation accommodation);
        void RemoveAccommodation(Accommodation accommodation);
        void RemoveAccommodation(string id);
        void UpdateAccommodation(string id, Accommodation accommodation);
    }
}