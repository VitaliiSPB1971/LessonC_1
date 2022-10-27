using System;
class HelloWorld {
  static void Main() {
    int count = 0;
    int distance = 10000;
    int firstSpeed = 1;
    int secondSpeed = 2;
    int dogSpeed = 5;
    int time = 0;
    while (distance > 10)
    {
        if(count % 2 == 0) {
            time = distance / (secondSpeed + dogSpeed);
        } else {
            time = distance / (firstSpeed + dogSpeed);
        }
        
        distance = distance - (firstSpeed + secondSpeed) * time;
        count++;
    }
    Console.Write("count = ");
    Console.WriteLine(count);

  }
}
