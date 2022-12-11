// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите коэффициенты");
Console.Write("K1= ");
decimal k1=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.Write("B1= ");
decimal b1=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.Write("K2= ");
decimal k2=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.Write("B2= ");
decimal b2=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ваши уравнения:");
Console.WriteLine($"y= {k1} x + {b1}");
Console.WriteLine($"y= {k2} x + {b2}");
decimal x=(b2-b1)/(k1-k2);
decimal y=k1*x+b1;
Console.WriteLine($"Точка пересечения ( {x}  ,  {y})");





