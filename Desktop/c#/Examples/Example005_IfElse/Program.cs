Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Ванька")
{
    Console.Write("Здарова ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}