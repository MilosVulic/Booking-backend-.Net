using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Recension
{
    [Route("api/[controller]")]
    public class RecensionsController : Controller
    {
        private readonly RecensionService _recensionService;

        public RecensionsController(RecensionService recensionService)
        {
            _recensionService = recensionService;
        }
        
        [HttpGet("{accommodationId}")]
        public ActionResult<List<Recension>> GetRecensionsByAccommodationId(string accommodationId)
        {
            return _recensionService.GetRecensionsForAccommodation(accommodationId);
        }
        
        [HttpGet]
        public ActionResult<List<Recension>> GetAllRecensions()
        {
            return _recensionService.GetAllRecensions();
        }
    }
}