using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Comments
{
    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{accommodationId}")]
        public ActionResult<List<Comment>> GetCommentsByAccommodationId(string accommodationId)
        {
            return _commentService.GetCommentsByAccommodation(accommodationId);
        }

        [HttpGet]
        public ActionResult<List<Comment>> GetAllComments()
        {
            return _commentService.GetAllComments();
        }
    }
}