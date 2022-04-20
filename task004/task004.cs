Console.WriteLine("1 число: ");
int a = int.Parse(Console.ReadLine());

int b = 7;
int c = 21;

if ((a % b == 0) & (a % c == 0))   // "и"
//if ((a % b == 0) | (a % c == 0))   // "или"
{
    Console.WriteLine($"кратно {a} и {b}");
}
else
{
    Console.WriteLine($"НЕ кратно {a} и {b}");
}