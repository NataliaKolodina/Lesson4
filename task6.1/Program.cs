void CatalogInfo(string path, string indent = "") //аргумент path - путь к текущей папке,
// indent - искусственный отступ, чтобы была видна структура папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем инфо о той директории, в которую зашли
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++) // получаем массив всех файлов, находящихся в этой папки
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles(); // весь список файлов в текущей директории
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path =
    @"/Users/Наталия/Desktop/Учеба GeekBrains/Знакомство с языком программирования С#/Lesson4/task1";
CatalogInfo(path);
