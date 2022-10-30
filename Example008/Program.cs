Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y = x % 2;
Console.Write("число ");
if (y == 0)
{
    Console.Write("четное");
}
else Console.Write("нечетное");
