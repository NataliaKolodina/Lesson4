// Задача. Перебор слов.
// В некотором машинном алфавите имеются 4 буквы.
// Покажите все слова, состоящие из Т букв, которые можно построить из этого алфавита.

Console.Clear();

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);
