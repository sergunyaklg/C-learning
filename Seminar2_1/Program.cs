int GenerateRandomNumber() 
{
    return new Random().Next(10,100);
}

int GetMaxDigitForDigitsNumber(int randomNumber)
{
    int firstDigit = randomNumber / 10;
    int secondDigit = randomNumber % 10;
    Console.WriteLine("Сгенерировали число в диапазоне [10, 99]: " + randomNumber);
    int max = firstDigit;
    if (secondDigit > firstDigit)
    {
        max = secondDigit;
    }
    return max;
}

int randomNumber = GenerateRandomNumber();
int max=GetMaxDigitForDigitsNumber(randomNumber);
Console.WriteLine("Наибольшая цифра числа: " + max);