// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
            double sumStr=0;
            int count=0;
            double avg=0;

Console.WriteLine("Введите размер массива");
int [] coord = Console.ReadLine().Split(" ").Select(s =>int.Parse(s)).ToArray();
int [,] matrix = new int [coord[0],coord[1]];
void InputMatrix(){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            matrix[i,j]=new Random().Next(0,100);
            Console.Write($"{matrix[i,j]}\t");

        }
    Console.WriteLine();
            

            

            
    Console.WriteLine();
                
    }
    
    
  
}
void AvgColums(){
sumStr=0;
     for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            

}
sumStr+=matrix[i,count];
     }
     Console.Write($"Сумма элементов {count} столбца {sumStr}");
     avg=Convert.ToDouble( sumStr/matrix.GetLength(1));
     Console.Write($" Среднее арифмитическое {count} столбца {Math.Round (avg,1)}");

         Console.WriteLine();

    count++;
    if(count<matrix.GetLength(1)){AvgColums();}
    else return;
}
InputMatrix();
AvgColums();
