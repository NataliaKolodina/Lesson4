// Задача. Сумма чисел от 1 до n.

Console.Clear();

int SumFor(int n)
{
    int res = 0;
    for (int i = 1; i <= n; i++)
        res += i;
    return res;
}

int SumRec(int n)
{
    if (n == 1)
        return 1;
    else
        return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
