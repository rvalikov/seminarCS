// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Enter M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int n=Convert.ToInt32(Console.ReadLine());
int Akkermann(int a,int b){
    if(a==0) return b+1;
    else if(a!=0 && b==0){
        return Akkermann(a-1,1);}
        else
        {
           return Akkermann(a-1,Akkermann(a,b-1));
        }
    }


int sum=Akkermann(n,m);
Console.WriteLine($"Akkermann= {sum}");