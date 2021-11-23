Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ксюша")
{
    Console.WriteLine("Ура, это же Ксюша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}