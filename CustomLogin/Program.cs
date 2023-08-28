
using CustomLogin.IO.Interfaces;
using CustomLogin.IO.Models;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

string test = reader.ReadLine();

writer.WriteLine(test);
writer.Write(test);
writer.Write(test);


