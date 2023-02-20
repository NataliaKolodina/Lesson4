// Задача. Собрать строку с числами от a до b, a <= b.

Console.Clear();
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumberRec(int a, int b)
{
    if (a <= b)
        return $"{a} " + NumberRec(a + 1, b);
    else
        return String.Empty;
}

Console.WriteLine(NumberFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumberRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
