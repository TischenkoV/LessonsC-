// Урок пятый, оригинальное приветствие юзеров
Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower == "маша")     // .ToLower переводит все символы в нижний регистр
{
    Console.WriteLine("Ура! Привет Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
