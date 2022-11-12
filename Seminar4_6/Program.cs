// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(0, 2);
        index++;
    } 
}

void PrintArray(int[] col)
{
    Console.WriteLine("Массив");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

Console.WriteLine("Введите число");
int number;
while (!int.TryParse(Console.ReadLine()!, out number) || number < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите число");
}

int[] array = new int[number];
FillArray(array);
PrintArray(array);