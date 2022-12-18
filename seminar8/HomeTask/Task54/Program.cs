// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.WriteLine($"Введите размер массива");
int [] coord = Console.ReadLine().Split(" ").Select(s=>int.Parse(s)).ToArray();
int [,] matrixOne = new int [coord[0],coord[1]];
void InputMatrix(){
    for(int i=0;i<coord[0];i++){
        for(int j=0;j<coord[1];j++){
            matrixOne[i,j]=new Random().Next(-10,10);
            
            Console.Write($"{matrixOne[i,j]}\t");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
        Console.WriteLine();

}
void SortMatrix(){
    for(int i=0; i<coord[0];i++){
    for(int j=0;j<coord[1]-1;j++){
       
        for(int k=1;k<coord[1];k++){
          
     int temp;
   
     if(matrixOne[i,k-1]<matrixOne[i,k]){
         temp=matrixOne[i,k];
         matrixOne[i,k]=matrixOne[i,k-1];
         matrixOne[i,k-1]=temp;
     }
        }
}
    }
}
void printmatrix(){
    for(int i=0;i<coord[0];i++){
        for(int j=0;j<coord[1];j++){
            
            
            Console.Write($"{matrixOne[i,j]}\t");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
        Console.WriteLine();

}

InputMatrix();
SortMatrix();
Console.WriteLine("Сортировка по убыванию");
printmatrix();