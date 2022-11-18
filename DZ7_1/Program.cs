// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

int[,] CreatArray (int rows, int colums)
{
    var random = new Random ();
    int [,] array = new int [rows, colums];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < colums; j++)
        {
            array [i, j] = random.Next (-100, 101);
        }
    }
    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            for (var k = 0; k < input.GetLength(0); k++)
            {
                for (var l = 0; l < input.GetLength(1); l++)
                {
                    if (input[i, j] < input[k, l])
                    {
                        var temp = input[i, j];
                        input[i, j] = input[k, l];
                        input[k, l] = temp;
                    }
                }
            }
        }
    }
    return input;
}

Console.WriteLine("Введите количество строк");
var rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
var colums = int.Parse(Console.ReadLine());
int[,] array = CreatArray(rows, colums);
Console.WriteLine("двумерный массив из целых чисел:");
PrintArray(array);
int [,] sortArray = SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(sortArray);