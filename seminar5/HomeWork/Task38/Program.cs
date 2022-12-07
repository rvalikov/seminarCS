// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double max;
double min;

void InputArray(double [] array){
for(int i=0;i<array.Length;i++){
    array[i]= new Random().NextDouble() * new Random().Next(-100,100);

}
}
void maxArray(double [] array){
max = array[0];
for(int i=0;i<array.Length; i++){
    if(max<array[i]){max=array[i];};
}
}
void minArray(double [] array){
min = array[0];
for(int i=0;i<array.Length; i++){
    if(min>array[i]){min=array[i];};
}
}

double [] array = new double [10];
Console.Clear();
InputArray( array);
maxArray(array);
minArray(array);
Console.WriteLine($"Array: [{String.Join(" ,", array)}]");
Console.WriteLine($"MAX: {max}");
Console.WriteLine($"MIN: {min}");
Console.WriteLine($"RESULT: {max-min}");



