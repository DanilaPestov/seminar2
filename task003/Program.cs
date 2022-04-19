Console.Clear();
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = a / b;
if (a % b == 0)
{
    Console.WriteLine("результат: " + result);
}
else
{
    int result2 = a % b;
    Console.WriteLine("не кратно, остаток " + result2);
}