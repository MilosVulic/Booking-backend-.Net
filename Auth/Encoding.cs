using System.Collections.Generic;
using System.Linq;

namespace Booking.Auth
{
    public static class Encoding
    {
        public static IEnumerable<User.User> WithoutPasswords(this IEnumerable<User.User> users) {
            return users.Select(x => x.WithoutPassword());
        }

        private static User.User WithoutPassword(this User.User user) {
            user.Password = null;
            return user;
        }
    }
}