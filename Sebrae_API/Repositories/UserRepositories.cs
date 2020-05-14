using System;
using System.Collections.Generic;
using System.Linq;
using Sebrae_API.Models;

namespace Sebrae_API.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "sebrae", Password = "sebrae", Role = "manager" });
            users.Add(new User { Id = 2, Username = "sebrae2", Password = "sebrae2", Role = "employee" });

            var usr = users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == x.Password.ToLower()).FirstOrDefault();

            if (usr != null)
            {
                if (username == usr.Username && password == usr.Password)
                {
                    return usr;
                }
                else
                {
                    return null;
                }
            }
            return usr;
        }
    }
}
