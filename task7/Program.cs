// Задачаю Пирамидки. Даны три шпиля. На первом n количество колец пирамиды.
// Нужно перемести кольца в том же порядке на третий шпиль

Console.Clear();

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// with - первый шпиль, откуда перекладываем
// on - третий шпиль, куда перекладываем
// some - второй шпиль, промежуточный
// count - количество блинов
{
    if (count > 1)
        Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1)
        Towers(some, on, with, count - 1);
}

Towers();
