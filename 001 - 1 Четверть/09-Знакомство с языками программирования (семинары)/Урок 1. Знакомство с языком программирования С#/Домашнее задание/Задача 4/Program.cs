Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int x3 = Convert.ToInt32(Console.ReadLine());

int max = x1;
if(x1 > max) max = x1;
if(x2 > max) max = x2;
if(x3 > max) max = x3; 

Console.WriteLine("Максимальное значение трёх чисел: " + max);
