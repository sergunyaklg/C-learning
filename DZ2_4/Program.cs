void Programmer(int quantity)
{
    if ((quantity % 100)/10 == 1)
    {
        Console.WriteLine("Программистов");
    }
    else if (quantity % 10 == 1)
    {
        Console.WriteLine("Программист");
    }
    else if (quantity % 10 > 1 && quantity % 10 < 5)
    {
        Console.WriteLine("Программиста");
    }
    else
    {
        Console.WriteLine("Программистов");
    }
}
Console.WriteLine("Введите количество программистов: ");
int quantity = Int32.Parse(Console.ReadLine());
Programmer(quantity);
