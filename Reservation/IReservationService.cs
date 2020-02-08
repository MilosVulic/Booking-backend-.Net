using System.Collections.Generic;

namespace Booking.Reservation
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservtionById(string id);
        Reservation InsertReservation(Reservation reservation);
        void RemoveReservation(Reservation reservation);
    }
}