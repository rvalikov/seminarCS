// ввод и  вывод массивов
Console.Clear();
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array=new int[n];
for(int i=0; i<array.Length;i++){
    Console.WriteLine($"Введите элемент {i+1} массива");
    array[i]=Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"[{String.Join(", ", array)}]");
