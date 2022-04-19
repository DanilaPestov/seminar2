//рандомное число
int numberA = new Random().Next(10, 100);
Console.WriteLine("наше число: " + numberA);
int b = numberA % 10;
int c = numberA / 10;
if (b > c) Console.WriteLine("наибольшее цифра: " + b);
else Console.WriteLine("наибольшая цифра: " + c);