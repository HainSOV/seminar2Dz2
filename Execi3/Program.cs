//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
bool weekdays(int day)
{
    if (day <= 5)
    {
        return true;
    }
    return false;
}

bool weektrue(int dayWeekTrue)
{
    if (dayWeekTrue > 0 && dayWeekTrue <= 7)
    {
        return true;
    }
Console.Write("Это не день недели");
return false;
}

Console.Write("Какой по счету день недели: ");
int Weekday = int.Parse(Console.ReadLine());
if (weektrue(Weekday))
{
    if (weekdays(Weekday))
    {
        Console.Write("Еще рабочий день");
    }
    else
    {
        Console.Write("Ураа, выходной!!");
    }
}