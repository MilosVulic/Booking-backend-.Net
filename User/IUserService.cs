using System.Collections.Generic;

namespace Booking.User
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUser(string id);
        User GetUserByCredentials(string username, string password); 
        User InsertUser(User user);
        void RemoveUser(User user);
        void RemoveUser(string id);
        void UpdateUser(string id, User user);
    }
}