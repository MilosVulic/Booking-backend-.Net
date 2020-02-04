using System.Collections.Generic;

namespace Booking.Apartment
{
    public interface IApartmentService
    {
        List<Apartment> GetApartmentsByAccommodation(string accommodationId);
        
        List<Apartment> GetAllApartments();

        Apartment InsertApartment(Apartment apartment);
    }
}