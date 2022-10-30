Console.WriteLine("Введите первое число ");
int a=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c=Convert.ToInt32 ( Console.ReadLine());
Console.Write("max = ");
if (a > b)
{   if (a > c)
    Console.WriteLine(a);
    else Console.WriteLine(c);
}
else {
        if (b > c) 
        Console.WriteLine(b);
        else Console.WriteLine(c);
    }
