// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void DegradingAinB(int A, int B)
{
    double result = Math.Pow(A, B);
    Console.WriteLine("Результат: " + result);
}



Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

DegradingAinB(A, B);