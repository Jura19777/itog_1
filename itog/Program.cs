// Написать программу
string[] CutArray(string[] array, int maxLength = 3)
{
    int y = 0;

    foreach (string el in array)
        if (el.Length <= maxLength)
            y++;

    string[] NewArray = new string[y];
    y = 0;

    foreach (string el in array)
        if (el.Length <= maxLength)
        {
            NewArray[y] = el;
            y++;
        }

    return NewArray;
}

// Вспомогательная функция для вывода массива в консоль
void ShowArrayString(string[] array, string msg = "Array")
{
    Console.WriteLine(msg + ":");

    foreach (string el in array)
        Console.Write(el + " ");

    Console.WriteLine();
}


string[] firstArray = new string[] { "Москва", "США", "ОК", ":-)" };

ShowArrayString(firstArray);
string[] resultArray = CutArray(firstArray);
ShowArrayString(resultArray, "New array");