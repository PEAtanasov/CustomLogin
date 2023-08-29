using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogin.Models
{
    public class User
    {
        private string userName;

        private string firstName;

        private string lastName;

        private string email;

        private string password;

        public User(string lastName, string firstName, string userName, string email, string password)
        {
            LastName = lastName;
            FirstName = firstName;
            UserName = userName;
            Email = email;
            Password = password;
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name is invalid");

                }

                lastName = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name is invalid");
                }
                firstName = value;
            }
        }

        public string UserName
        {
            get { return userName; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username invalid");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentException("Username cannot be less than 2 symbols");
                }

                userName = value;
            }
        }

        public string Email
        {
            get => email;
            private set
            {
                email = value;
            }
        }
        protected string Password
        {
            get => password;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid password");
                }

                if (value.Length <= 5)
                {
                    throw new ArgumentException("Password should be atleast 6 symbols");
                }

                if (!IsPassValid(value))
                {
                    throw new ArgumentException("Invalid Passowrd");
                }

                password = value;
            }

            
        }

        public bool IsLoggIn { get; set; } = false;
        private bool IsPassValid(string value)
        {
            int upperCount = 0;
            int lowerCount = 0;
            int digitCount = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    upperCount++;
                }
                else if (char.IsLower(value[i]))
                {
                    lowerCount++;
                }
                else if (char.IsDigit(value[i]))
                {
                    digitCount++;
                }
            }

            if (upperCount == 0 || lowerCount == 0 || digitCount == 0)
            {
                return false;
            }

            return true;
        }

        public bool PassVerification(string email, string password)
        {
            if (Email != email)
            {
                return false;
            }

            if (Password != password)
            {
                return false;

            }

            return true;
        }

        public void UserLoggIn()
        {
            if (!IsLoggIn) { IsLoggIn = true; }           
        }

        public void UserLoggOut()
        {
            if (IsLoggIn) { IsLoggIn = false; }
        }

    }
}
