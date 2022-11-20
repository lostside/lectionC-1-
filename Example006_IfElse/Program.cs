Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "liza")
{
    Console.WriteLine("Ура, это любимая!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}