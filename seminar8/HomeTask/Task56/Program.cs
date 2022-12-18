// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.WriteLine("Введите размер массива");
int [] coord = Console.ReadLine().Split(" ").Select(s =>int.Parse(s)).ToArray();
int [,] matrix = new int [coord[0],coord[1]];
InputMatrix();
int [] sumStr = new int [matrix.GetLength(0)];
SummingString();
int sumMin=sumStr[0];
MinSumm();
void InputMatrix(){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            matrix[i,j]=new Random().Next(-100,100);
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }

}
void SummingString(){
for(int i=0;i<sumStr.Length;i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            sumStr[i]+=matrix[i,j];  
            Console.Write($"Sumstr {i}= {sumStr[i]}\t");
        }
    Console.WriteLine();
    }
}
void MinSumm(){
for(int i=0;i<sumStr.Length;i++){
    if(sumMin>sumStr[i]){sumMin=sumStr[i];}
}
Console.Write($"Summin = {sumMin}\t");}

