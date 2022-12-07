// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int count=0;

void InputArray (int [] array)
{
for (int i=0; i<array.Length;i++){
    array[i]=new Random().Next(100,1000);

}
}
void countArray(int [] array)
{
for (int i=0; i<array.Length;i++){

    if(array[i]%2==0){count++;};
}
}

int [] array= new int [10];
Console.Clear();
InputArray(array);
countArray(array);
Console.WriteLine($"Array: [{String.Join(" ,", array)}]");
Console.WriteLine($"Count= {count}");