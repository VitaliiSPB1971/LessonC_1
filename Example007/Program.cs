Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y=2;
while (y <= x)
{
    if(y % 2 == 0 && y != x){
        Console.Write(y + ", ");
    }
    if(y % 2 == 0 && y == x) {
        Console.Write(y + " ");
    }
    y++;
}
