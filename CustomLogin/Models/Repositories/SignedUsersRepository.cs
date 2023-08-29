using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogin.Models.Repositories
{
    public class SignedUsersRepository
    {
        private readonly List<User> users;

        public SignedUsersRepository()
        {
            users = new List<User>();
        }

        public ICollection<User> Users => this.users;


        public void AddUser(User user)
        {
            if (!IsUserRegistered(user.UserName,user.Email))
            {
                users.Add(user);
            }
        }

        public void RemoveUser(User user) 
        {
            if (IsUserRegistered(user.UserName,user.Email))
            {
                users.Remove(user);
            }
        }
        public User GetUser(string username)
        {
            return this.users.FirstOrDefault(u => u.UserName == username);  
        }

        public bool IsUserRegistered(string username, string email)
        {
            User user = this.users.FirstOrDefault(u => u.UserName == username && u.Email == email);

            if (user==null)
            {
                return false;
            }

            return true;
        }
    }
}
