using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Accommodation
{
    [Route("api/[controller]")]
    public class AccommodationsController : Controller
    {
        private readonly AccommodationService _accommodationService;

        public AccommodationsController(AccommodationService accommodationService)
        {
            _accommodationService = accommodationService;
        }

        [HttpGet]
        public ActionResult<List<Accommodation>> GetAllAccommodations()
        {
            return _accommodationService.GetAllAccommodations();
        }
    }
}