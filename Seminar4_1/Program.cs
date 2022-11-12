int[] CreatArrayWithRandomNumbers(int numbers = 12, 
                                  int startInterval = -9, 
                                  int endInterval = 9)
   {
        int[] result = new int[numbers];
        Random random = new();

        for (int i = 0; i < numbers; i++)
        {
            result[i] = random.Next(startInterval, endInterval+1);

        }
        return result;
   }

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (i == input.Length - 1)
        {
            Console.Write(input[i]);
        }
        else
        {
            Console.Write(input[i] + ", ");
        }
    }
    Console.WriteLine();
}

int SumPositiveNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > 0)
        {
            result += input[i];
        }
    }
    return result;

}

int SumNegativeNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] < 0)
        {
            result += input[i];
        }
    }
    return result;
}

var array = CreatArrayWithRandomNumbers();
Print(array);
var positiveSum = SumPositiveNumbers(array);
Console.WriteLine($"Sum of positive numbers: {positiveSum}");
var negativeSum = SumNegativeNumbers(array);
Console.WriteLine($"Sum of negative numbers: {negativeSum}");
