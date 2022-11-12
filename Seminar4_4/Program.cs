// Напишите программу, которая принимает на вход число и выдаёёт количествоо цифр в числе.

Console.ResetColor();
Console.Write("Введите число: ");

string str = Console.ReadLine().Trim();

int n;

if (int.TryParse(str, out n))
{
    Console.WriteLine("");
    Console.WriteLine("Результат: " + IntLength(n));  
    
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("* для завершения задачи нажмите любую клавишу...");
    Console.ResetColor();
    Console.ReadKey(true);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибка: несоответствие типу integer!");
}
int IntLength(int n)
{
    n=Math.Abs(n);
    int result = 0;
    do
    {
        n /= 10;
        result++;
    } while (n > 0);

    return result;
}