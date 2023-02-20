// Задача. Информация о заданной папки

Console.Clear();
string path =
    "/Users/Наталия/Desktop/Учеба GeekBrains/Знакомство с языком программирования С#/Lesson4"; // адрес нашей папки
DirectoryInfo di = new DirectoryInfo(path); // DirectoryInfo - позволяет получить иформацию о директории
Console.WriteLine(di.CreationTime); // дата создания папки

FileInfo[] fi = di.GetFiles(); // какие файлы находятся в этой папке // FleInfo - позволяет получить иформацию о файлах
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
