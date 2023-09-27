
Console.WriteLine ("Введите число обозначающее день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 5)
{
    Console.WriteLine ($"{number} -> Нет");
}
else if (number > 5 && number < 8)
{
    Console.WriteLine ($"{number} -> Да");
}
else if(number > 7)
{
    Console.WriteLine ($"{number} -> Неккоректный ввод");
}
