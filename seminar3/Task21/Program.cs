Console.Clear();
Console.Write("Введите координаты x1,y1,z1 ");

double x1=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2,y2,z2 ");

double x2=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
double z2=Convert.ToDouble(Console.ReadLine());
double length;
length = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.Write($" Длина {length}");
