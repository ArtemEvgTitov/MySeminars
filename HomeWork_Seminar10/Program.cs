// Задайте массив строк. Напишите программу, которая считает количество слов в массиве, начинающихся на гласную букву.

int VowelLetters(string[] array)
{
    int count = 0;
    char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };

    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < vowel.Length; j++)
            if (char.ToLower(array[i][0]) == vowel[j])
                count++;

    return count;
}
string[] words = { "qwe", "wer", "Ert", "aty", "tyu", "yui" };
Console.WriteLine($"Общее количество слов в массиве, начинающихся на гласную букву равно: {VowelLetters(words)}");

// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CombiningWords(string[] array)
{
    string[] combiningWords = new string[array.Length / 2];

    for (int i = 0, j = 0; i < array.Length; i += 2, j++)
        combiningWords[j] = array[i] + array[i + 1];

    return combiningWords;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] moreWords = { "qwe", "wer", "Ert", "aty", "tyu", "yui" };

string[] combiningWords = CombiningWords(moreWords);
ShowArray(combiningWords);