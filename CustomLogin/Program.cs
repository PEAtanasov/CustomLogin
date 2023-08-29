using CustomLogin.IO.Interfaces;
using CustomLogin.IO.Models;
using CustomLogin.Models;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

User user=default;

try
{
    user = new("Atanasov", "Petar", "Test", "atanasov@test.com", "AbvAbv1");
}
catch (Exception ex)
{
    writer.WriteLine(ex.Message);
}

writer.WriteLine(user.FirstName + " " + user.LastName);



