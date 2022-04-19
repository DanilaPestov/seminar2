//последняя цифра числа
Console.WriteLine("введите число: ");

int num = int.Parse(s: Console.ReadLine());

Console.WriteLine("последняя цифра: " + num % 10);

//вторая цифра числа
Console.WriteLine("введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());

number = number % 100;
number = number / 10;
Console.WriteLine($"вторая цифра: " + number);