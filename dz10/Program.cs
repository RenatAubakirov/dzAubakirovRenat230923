int SecondNumber(int num)
{
    return (num % 100)/ 10;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    int number2 = SecondNumber(number);
    Console.WriteLine($"{number} -> {number2}");
}
else Console.WriteLine ("Ошибка ввода");