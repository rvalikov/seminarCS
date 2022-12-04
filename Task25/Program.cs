// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите основание степени");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени");
int b=Convert.ToInt32(Console.ReadLine());
int i = 2;
int res=a;
while( i<=b)
{


    res=a*res;
    i++;
}
Console.WriteLine($"Результат {res}");

