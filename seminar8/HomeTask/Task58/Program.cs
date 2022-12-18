// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.WriteLine($"Введите размер массива");

int [] coord = Console.ReadLine().Split(" ").Select(s=>int.Parse(s)).ToArray();

int [,] matrixOne = new int [coord[0],coord[1]];
int [,] matrixTwo = new int [coord[0],coord[1]];
int [,] matrixRes = new int [coord[0],coord[1]];

void InputMatrix(int [,] matrix){
    for(int i=0;i<coord[0];i++){
        for(int j=0;j<coord[1];j++){
            matrix[i,j]=new Random().Next(-10,10);
            
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
        Console.WriteLine();

}

InputMatrix(matrixOne);
InputMatrix(matrixTwo);
void MultyMatrix(){
    Console.WriteLine($"произведение");
    for(int i=0;i<coord[0];i++){
        for(int j=0;j<coord[1];j++){
            matrixRes[i,j]=matrixOne[i,j]*matrixTwo[i,j];
           
            Console.Write($"{matrixRes[i,j]}\t");
           

}
Console.WriteLine();
    }
}
MultyMatrix();

