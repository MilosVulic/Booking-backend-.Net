using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Apartment
{
    [Route("api/[controller]")]
    public class ApartmentsController : Controller
    {
        private readonly ApartmentService _apartmentService;

        public ApartmentsController(ApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet("{accommodationId}")]
        public ActionResult<List<Apartment>> GetApartmentsByAccommodationId(string accommodationId)
        {
            return _apartmentService.GetApartmentsByAccommodation(accommodationId);
        }
        
        [HttpGet]
        public ActionResult<List<Apartment>> GetAllApartments()
        {
            return _apartmentService.GetAllApartments();
        }
    }
}