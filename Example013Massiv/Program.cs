int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, 1 };// создаём массив

void PrintArray(int[] array)// В качестве аргумента приходим массив
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");// Выводим на экран через пробел
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)// пробегаемся по всей доинне массива
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];// Присваеваем временную посицию
        array[i] = array[minPosition];//Происходит обмен двух переменных местами
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
