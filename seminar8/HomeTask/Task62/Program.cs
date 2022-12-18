// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
string [,] arroy = new string [4,4];
int i=0;
int j;
int count =0;

//Заполнение первой строки
    for( j=0; j<4;j++){
        arroy[i,j]=count.ToString("00");
        count++;}
    
   
   //Заполнение последнего столбца
   j=3;
     for( i=1; i<4;i++){
       arroy[i,j]=count.ToString("00");
       count++;
     }
    
    //Заполнение последней строки
    i=3;
    for( j=2; j>=0;j--){
       arroy[i,j]=count.ToString("00");
       count++;
    } 
   //
     j=0;
     for( i=2; i>=1;i--){
       arroy[i,j]=count.ToString("00");
       count++;
     }
     i=1;
     for( j=1; j<3;j++){
       arroy[i,j]=count.ToString("00");
       count++;}
       i=2;
     for( j=2; j>=1;j--){
       arroy[i,j]=count.ToString("00");
       count++;}
       void PrintArroy(){
       for(int i=0;i<4;i++){
        for(int j=0;j<4;j++){
           
            Console.Write($"{arroy[i,j]}\t");
        }
       Console.WriteLine();
       }

       }
    
       PrintArroy();



   


