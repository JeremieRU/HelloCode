Console.Write("Input Username: ");
string username = Console.ReadLine();

if (username.ToLower() == "jeremie")
{
    Console.WriteLine("Hooray, it`s Jeremie!!!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
    Console.WriteLine("!");
}