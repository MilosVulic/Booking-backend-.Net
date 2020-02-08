using System;
using System.Collections.Generic;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly IMongoCollection<Reservation> _reservations;
        
                public ReservationService(IBookingDatabaseSettings settings)
                {
                    var client = new MongoClient(settings.ConnectionString);
                    var database = client.GetDatabase(settings.DatabaseName);
        
                    _reservations = database.GetCollection<Reservation>(settings.ReservationCollectionName);
                }

                public List<Reservation> GetAllReservations()
                {
                    return _reservations.Find(reservation => true).ToList();
                }

                public Reservation GetReservtionById(string id)
                {
                    return _reservations.Find(res => res.Id == id).FirstOrDefault();
                }

                public Reservation InsertReservation(Reservation reservation)
                {
                    reservation.Id = Guid.NewGuid().ToString();
                    _reservations.InsertOne(reservation);
                    return reservation;
                }

                public void RemoveReservation(Reservation reservation)
                {
                    _reservations.DeleteOne(res => res.Id == reservation.Id);
                }
    }
}