using System;
using System.Collections.Generic;
using Booking.Config;
using MongoDB.Driver;

namespace Booking.User
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IBookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public List<User> GetAllUsers()
        {
            return _users.Find(user => true).ToList();
        }

        public User GetUser(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public User GetUserByCredentials(string username, string password)
        {
            return _users.Find(user => user.Username == username && user.Password == password).FirstOrDefault();
        }

        public User InsertUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            _users.InsertOne(user);
            return user;
        }

        public void RemoveUser(User userIn)
        {
            _users.DeleteOne(user => user.Id == userIn.Id);
        }

        public void RemoveUser(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }

        public void UpdateUser(string id, User userIn)
        {
            _users.ReplaceOne(user => user.Id == id, userIn);
        }
    }
}