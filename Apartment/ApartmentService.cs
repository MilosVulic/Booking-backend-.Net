using System.Collections.Generic;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.Apartment
{
    public class ApartmentService : IApartmentService
    {
        private readonly IMongoCollection<Apartment> _apartments;

        public ApartmentService(IBookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _apartments = database.GetCollection<Apartment>(settings.ApartmentCollectionName);
        }
        
        public List<Apartment> GetApartmentsByAccommodation(string accommodationId)
        {
            return _apartments.Find(apartment => apartment.AccommodationId == accommodationId).ToList();
        }

        public List<Apartment> GetAllApartments()
        {
            return _apartments.Find(apartment => true).ToList();
        }

        public Apartment InsertApartment(Apartment apartment)
        {
            _apartments.InsertOne(apartment);
            return apartment;
        }
    }
}