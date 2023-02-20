// Решение некоторых задач
// Обход разных структур
//           ((4 - 2) * (1 + 3) / 10)
// индексы:    8 4 9  2 10 5 11 1  3

Console.Clear();
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

//                  0,  1,   2,    3,   4,   5,    6,   7,  8,   9,   10,  11

void InOrderTraversa(int pos = 1) // метод, делающий обход, аргумент - начинаем с позиции 1
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))
            InOrderTraversa(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right]))
            InOrderTraversa(right);
    }
}

InOrderTraversa();
