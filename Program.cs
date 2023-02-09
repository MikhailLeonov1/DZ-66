Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма элементов в промежутке: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);