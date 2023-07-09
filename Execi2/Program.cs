int thirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool notThreeDigit(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Число не трехзначное");
        return false;
    }
    return true;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (notThreeDigit(number))
{
    Console.WriteLine(thirdRank(number));
}