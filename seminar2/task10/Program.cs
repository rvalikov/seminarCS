// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа;
Console.Clear();

Console.WriteLine("Введите трехзначное  число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a%100;
int c=b/10;
Console.WriteLine($"Вторая цифра Вашего числа {c}");

