Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number < 100 || number > 1000)
{
    Console.WriteLine("Вы вели не рехзначное число, попробуйте снова");
    return;
}
Console.Write("вторая цифра трехзначного числа: " + number / 10 % 10);
