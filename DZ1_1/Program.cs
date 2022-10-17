Console.WriteLine("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine());

int maxnumber;
int minnumber;

// int maxnumber = Math.Max(a, b);
// int minnumber = Math.Min(a, b);

if ( a > b ) 
{
   maxnumber = a;
   minnumber = b;
} 
else 
{
   maxnumber = b;
   minnumber = a;
}


Console.WriteLine($"Максимальное число: {maxnumber}. Минимальное число: {minnumber}");