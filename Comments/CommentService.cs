using System.Collections.Generic;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.Comments
{
    public class CommentService : ICommentService
    {
        
        private readonly IMongoCollection<Comment> _comments;

        public CommentService(IBookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _comments = database.GetCollection<Comment>(settings.CommentCollectionName);
        }
        
        public List<Comment> GetCommentsByAccommodation(string accommodationId)
        {
            return _comments.Find(comment => comment.AccommodationId == accommodationId).ToList();
        }

        public List<Comment> GetAllComments()
        {
            return _comments.Find(comment => true).ToList();
        }

        public Comment InsertComment(Comment comment)
        {
            _comments.InsertOne(comment);
            return comment;
        }
    }
}