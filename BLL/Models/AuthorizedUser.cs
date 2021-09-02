using System;

namespace BLL.Models
{
    public class AuthorizedUser : User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }

        public AuthorizedUser(string email, string password)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
        }
        public AuthorizedUser(string email, string password, string firstName, string secondName, string phoneNumber)
        {
            Id = Guid.NewGuid();

            Email = email;
            Password = password;

            FirstName = firstName;
            SecondName = secondName;
            PhoneNumber = phoneNumber;
        }
    }
}
