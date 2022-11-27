// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();


Console.WriteLine("Введите   число");
int a=Convert.ToInt32(Console.ReadLine());
if ((a<100  && a>-100 ) ){
Console.WriteLine($"третьей цифры нет ");}


else 
if(a>=100 && a<1000){
    int b=a%10;
    
    Console.WriteLine($"третья цифра Вашего числа {b}");
}
if (a>=1000 && a<10000){
    int b=(a/10)%10;
    
    Console.WriteLine($"третья цифра Вашего числа {b}");

}
else if (a>=10000&& a<100000) {
    int b=(a/100)%10;
    
    Console.WriteLine($"третья цифра Вашего числа {b}");

}
else if (a>=100000 && a<1000000){
    int b=(a/1000)%10;
    
    Console.WriteLine($"третья цифра Вашего числа {b}");
}


