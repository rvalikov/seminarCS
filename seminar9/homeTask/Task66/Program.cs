// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Enter M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int n=Convert.ToInt32(Console.ReadLine());
int summ(int a,int b){
    if(a==b) return b;
    return summ(a+1,b)+a;
}

int sum=summ(m,n);
Console.WriteLine($"summ= {sum}");