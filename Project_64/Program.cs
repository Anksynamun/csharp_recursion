// See https://aka.ms/new-console-template for more information
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(n, 1));
string PrintNumbers(int end, int start)
{
    if (end == start) return end.ToString();
    return (end + ", " + PrintNumbers(end - 1, start));
}