// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result ++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {result}");
}

Console.Write("Введите числа через запятую: ");
int[] array = Console.ReadLine().Split(", ").Select(x=>int.Parse(x)).ToArray();
CountPositiveNumbers(array);