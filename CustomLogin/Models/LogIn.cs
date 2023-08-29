using CustomLogin.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogin.Models
{
    public class LogIn
    {
        private SignedUsersRepository users;

        public LogIn(SignedUsersRepository users)
        {
            this.users = users;
        }
        public void LoginToLogings(User user)
        {        
                User user1 = users.GetUser(user.UserName);
                user1.UserLoggIn();

                Console.WriteLine("Success"); 
        }
    }
}
