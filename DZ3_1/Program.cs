// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

bool isPolindrom(int x) {
    int y = 0;
    int z = x;
    while (z > 0) {
        y = y * 10 + z % 10;
        z /= 10;
    }
    return x == y;
}


Console.WriteLine("Введите число для проверки на палиндром: ");
if (isPolindrom(int.Parse(Console.ReadLine()))) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}