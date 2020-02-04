using System;
using System.Collections.Generic;
using System.Linq;
using Booking.Accommodation;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.Recension
{
    public class RecensionService : IRecensionService
    {
        private readonly IMongoCollection<Recension> _recensions;
        private readonly AccommodationService _accommodationService;

        public RecensionService(IBookingDatabaseSettings settings, AccommodationService accommodationService)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _recensions = database.GetCollection<Recension>(settings.RecensionCollectionName);
            _accommodationService = accommodationService;
        }

        public List<Recension> GetRecensionsForAccommodation(string accommodationId)
        {
            return _recensions.Find(recension => recension.AccommodationId == accommodationId).ToList();
        }

        public List<Recension> GetAllRecensions()
        {
            return _recensions.Find(recension => true).ToList();
        }

        // Logic for inserting new recension but also updating overall recension of the current accomodation
        public void InsertRecension(Recension recension)
        {
            _recensions.InsertOne(recension);
            var recensionList = GetRecensionsForAccommodation(recension.AccommodationId);
            var accommodation = _accommodationService.GetAccommodation(recension.AccommodationId);
            
            var size = recensionList.Count;
            var count = recensionList.Sum(rec => rec.NumberOfStars);
            var averageRecension = count / size;
            
            if (accommodation == null) return;
            accommodation.NumberOfRecensions = size;
            accommodation.AverageRecension = averageRecension;
            _accommodationService.UpdateAccommodation(recension.AccommodationId, accommodation);

        }
    }
}