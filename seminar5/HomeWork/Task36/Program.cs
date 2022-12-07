// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int sum=0;
void InputArray(int [] array){
    for(int i=0;i<array.Length;i++){
        array[i]=new Random().Next(-100,100);
    }
}
int ResArray(int [] array){
        for(int i=1;i<array.Length;i+=2)

        {    Console.WriteLine($"i= {i}");
            
            sum+=array[i];
            Console.WriteLine($"SUMM= {sum}");
        }
return sum;
}

int [] array= new int [10];
Console.Clear();
InputArray(array);
ResArray(array);
Console.WriteLine($"Array: [ {String.Join(" ,",array)}]");
Console.WriteLine($"SUMM:  {sum}");