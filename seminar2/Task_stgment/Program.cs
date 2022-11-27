//принимает два числа и проверяет одно - квадрат другого?
Console.Clear();
Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
int c=a%b;
if (b*b==a || a*a==b) {Console.WriteLine("Квадрат");}
else
{
    Console.WriteLine("false");
}

