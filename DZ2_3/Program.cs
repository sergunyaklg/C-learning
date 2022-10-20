void DayOfWeek(int day)
{
if (day > 5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
}

Console.WriteLine("Введите число дня недели, чтоб узнать выходной ли это день: ");
int day = Int32.Parse(Console.ReadLine());
DayOfWeek(day);