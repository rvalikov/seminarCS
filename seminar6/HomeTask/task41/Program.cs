﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.WriteLine("Ввежите количество чисел");
int size= Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
int count=0;
for(int i=0;i<size;i++){
    Console.WriteLine("Введите  число");

    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0){count++;}
    
}
Console.WriteLine($"Вы ввели: {String.Join(", ",array)}");

Console.WriteLine($"Количество положительных: {count}");
