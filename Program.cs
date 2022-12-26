// Задача. Проверить элементы массива, если элемент больше трёх символов, то его удалить. Вывести оставшиеся элементы.

string[] array = { "hello", "2", "world", ":)"};

System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
Console.ReadLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length >= 3)
    {
        array = RemoveArray(array, i);
    }
}

System.Console.WriteLine("Итоговый массив: ");
PrintArray(array);

// string[] RemoveArray(string[] array, int index)
// {
//     string[] newArray = new string[array.Length - 1];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < index)
//         {
//             newArray[i] = array[i];
//         }
//         else if (i > index)
//         {
//             newArray[i - 1] = array[i];
//         }
//     }
//     array = newArray;
//     return newArray;
// }

string[] RemoveArray(string[] array, int index)
{
    string[] newArray = new string[array.Length  - 1];
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = index + 1; i < array.Length; i++)
    {
        newArray[i - 1] = array[i];
    }
    array = newArray;;
    return newArray;
}


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "," + " ");
    }
    Console.Write("]");
    System.Console.WriteLine();
}