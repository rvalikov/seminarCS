//Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
    Console.Clear();
Console.Write("Введите пятизначное число ");
int numBegin = Convert.ToInt32(Console.ReadLine());
int numres;
int a;
int num=numBegin;
Console.Write($" Ваше число {num}");

a=num%10;
num=num/10;
numres=a*10000;

a=num%10;
num=num/10;
numres+=a*1000;

a=num%10;
num=num/10;
numres+=a*100;

a=num%10;
num=num/10;
numres+=a*10;

a=num%10;
num=num/10;
numres+=a*1;

if ((numBegin-numres)==0){Console.WriteLine(" YES");}
else{Console.WriteLine(" NO");}