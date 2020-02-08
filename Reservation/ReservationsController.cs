using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Reservation
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ReservationController : Controller
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        
        [HttpGet]
        public ActionResult<List<Reservation>> GetAllReservations()
        {
            return _reservationService.GetAllReservations();
        }
        
        [HttpGet("{reservationId}")]
        public ActionResult<Reservation> GetReservationByReservationId(string reservationId)
        {
            return _reservationService.GetReservtionById(reservationId);
        }
        
        [HttpPost]
        public ActionResult<Reservation> PostReservations([FromBody]Reservation reservation)
        {
            return _reservationService.InsertReservation(reservation);
        }
    }
}