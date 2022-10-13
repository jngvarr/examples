Console.WriteLine("Введите имя пользователя");

string userName=Console.ReadLine();
if (userName == "Маша")
{
    Console.WriteLine("Ура!!! Это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}