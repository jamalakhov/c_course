Console.Clear();
Console.Write("Введите ваше имя: ");
string inputUserName = Console.ReadLine();

if (myEquals(inputUserName, "Маша"))
{
    Console.WriteLine("Это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + inputUserName);
}


bool myEquals(string obj1, string obj2)
{
    if (obj1.ToLower() == obj2.ToLower()) return true;
    else return false;

}
