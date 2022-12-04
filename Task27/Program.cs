// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32 (Console.ReadLine());
int sum=0;
string nStr=Convert.ToString(n);
for(int i=0; i<nStr.Length;i++){
    string k=nStr[i].ToString();
    int p=Int32.Parse(k);
     sum+=p;
}
    Console.WriteLine("sum= " + sum);
