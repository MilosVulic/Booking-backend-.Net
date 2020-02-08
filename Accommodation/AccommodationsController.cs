using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Accommodation
{
    [Route("api/[controller]")]
    [Produces("application/json")]
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
        
        [HttpPost]
        public ActionResult<Accommodation> PostAccommodation([FromBody]AccommodationDTO accommodation)
        {
           return _accommodationService.InsertAccommodation(new Accommodation()
            {
                Name = accommodation.Name,
                Address = new Address()
                {
                    City = accommodation.Address.City,
                    Street = accommodation.Address.Street,
                    Country = accommodation.Address.Country
                },
                UrlPic = accommodation.UrlPic
            });
        }
    }
}