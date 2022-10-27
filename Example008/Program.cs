int count = 0;
int distance = 10000;
int firstSpeed = 1;
int secondSpeed = 2;
int dogSpeed = 5;
bool friend = true;
int time = 0;
while (distance > 10)
{
if (friend == false)
 { time = distance / (firstSpeed + dogSpeed);
   friend = true;
        time = distance / (secondSpeed + dogSpeed);
        friend = false;
distance = distance - (firstSpeed + secondSpeed) * time;
count++;
 }
    }
Console.Write("count = ");
Console.WriteLine(count);