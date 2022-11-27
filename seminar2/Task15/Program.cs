// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

int i;
do{
Console.WriteLine("Введите   число от 1 до 7");
 i=Convert.ToInt32(Console.ReadLine());
}
while(i<=0 || i>7);
if (i==6 || i==7)Console.WriteLine("YES");
else Console.WriteLine("NO");


