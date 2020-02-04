using System.Collections.Generic;

namespace Booking.Comments
{
    public interface ICommentService
    {
        List<Comment> GetCommentsByAccommodation(string accommodationId);

        List<Comment> GetAllComments();

        Comment InsertComment(Comment comment);
    }
}