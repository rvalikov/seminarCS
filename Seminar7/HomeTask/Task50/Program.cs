// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет
Console.Clear();
Console.WriteLine("Введите размер массива");
int [] coord = Console.ReadLine().Split(" ").Select(s =>int.Parse(s)).ToArray();
int [,] matrix = new int [coord[0],coord[1]];
void InputMatrix(){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            matrix[i,j]=new Random().Next(-100,100);
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }

}
InputMatrix();
Console.WriteLine("Введите строку искомого элемента ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента ");

int colums = Convert.ToInt32(Console.ReadLine());
if(row>matrix.GetLength(0)-1|| colums>matrix.GetLength(1)-1){Console.WriteLine("Нет такого элемента");}
else{
Console.WriteLine($"[{row},{colums}] = {matrix[row,colums]}");
}

