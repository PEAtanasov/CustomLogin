using CustomLogin.IO.Interfaces;
using CustomLogin.IO.Models;
using CustomLogin.Models;
using CustomLogin.Models.Repositories;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
SignedUsersRepository registeredUsers = new();

LogIn logIn = new LogIn(registeredUsers);

User user=default;
User user1 = default;

try
{
    user = new("Atanasov", "Petar", "Test", "atanasov@test.com", "AbvAbv1");
    user1 = new("Atanasov1", "Petar1", "Test1", "atanasov@test.com", "AbvAbv2");
}
catch (Exception ex)
{
    writer.WriteLine(ex.Message);
}

registeredUsers.AddUser(user);
registeredUsers.AddUser(user1);

logIn.LoginToLogings(user);
logIn.LoginToLogings(user1);


//writer.WriteLine(user.FirstName + " " + user.LastName);



