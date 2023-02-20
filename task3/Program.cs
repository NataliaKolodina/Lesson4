// Задача. Факториал числа

Console.Clear();
int FactorialFor(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
        res *= i;
    return res;
}

int FactorialRec(int n)
{
    if (n == 0)
        return 1;
    else
        return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
