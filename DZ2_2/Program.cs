//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
void FindThirdDigit(int Number)
{
    int quantityOfDigits = 0;
    int Number1 = Number;
    while(Number1>0) 
    {
        quantityOfDigits++;
        Number1/=10;
    }

    if(quantityOfDigits > 2) 
    {
        int remain = Number / ((int)Math.Pow(10,(quantityOfDigits-3))) % 10;
        Console.WriteLine("Третья цифра: " + remain);
    }
    else 
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

Console.WriteLine("Введите число: ");
int Number = Int32.Parse(Console.ReadLine());
FindThirdDigit(Number);
