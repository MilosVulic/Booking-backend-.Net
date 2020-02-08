using System;
using System.Collections.Generic;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.Accommodation
{
    public class AccommodationService : IAccommodationService
    {
        private readonly IMongoCollection<Accommodation> _accommodations;

        public AccommodationService(IBookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _accommodations = database.GetCollection<Accommodation>(settings.AccommodationCollectionName);
        }

        public List<Accommodation> GetAllAccommodations()
        {
            return _accommodations.Find(accommodation => true).ToList();
        }

        public Accommodation GetAccommodation(string id)
        {
            return _accommodations.Find(accommodation => accommodation.Id == id).FirstOrDefault();
        }

        public Accommodation InsertAccommodation(Accommodation accommodation)
        {
            accommodation.Id = Guid.NewGuid().ToString();
            _accommodations.InsertOne(accommodation);
            return accommodation;
        }

        public void RemoveAccommodation(Accommodation accommodationIn)
        {
            _accommodations.DeleteOne(accommodation => accommodation.Id == accommodationIn.Id);
        }

        public void RemoveAccommodation(string id)
        {
            _accommodations.DeleteOne(accommodation => accommodation.Id == id);
        }

        public void UpdateAccommodation(string id, Accommodation accommodationIn)
        {
            _accommodations.ReplaceOne(accommodation => accommodation.Id == id, accommodationIn);
        }
    }
}