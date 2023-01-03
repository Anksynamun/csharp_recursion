// See https://aka.ms/new-console-template for more information
Console.Write("Введите начальное число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(PrintNumber(n, m));
int PrintNumber(int n, int m)
{
    if (n == m) return n;
    return (n + PrintNumber(n + 1, m));
}