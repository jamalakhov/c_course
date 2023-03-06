Console.Clear();
Console.Write("Введите ваше имя: ");

var inputUserName = Console.ReadLine();

if (inputUserName != null)
{
    if (myEquals(inputUserName.ToString(), "Маша"))
    {
        Console.WriteLine("Это же МАША!");
    }
    else
    {
        Console.WriteLine("Привет, " + inputUserName);
    }
}
else
{
    System.Console.WriteLine("Input is null!");
}

bool myEquals(string obj1, string obj2)
{
    if (obj1.ToLower() == obj2.ToLower()) return true;
    else return false;

}
