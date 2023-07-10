int[] array = {12, 56, 34, 56, 35, 63, 79, 28, 63};

int n = array.Length;// показывает длинну (колличество элементов массива)
int find = 63;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;// Остановит цикл при нахождении первого искомого числа и не выведет второе, если есть 2 одинаковых числа
    }
    index++;
}
