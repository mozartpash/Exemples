void Fillarray(int[] collection)
{
    int length = collection.Length;// Получаем длинну массива по имени collection
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)//void - это метод, который не возвращает данные. При этом мы не ставим return
{
    int cout = col.Length;
    int position = 0;
    while(position < cout)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// Если искомого элемента нет, то позиция вернёт на -1
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];// new int[10] Создали новый массив, в котором будет 10 элементов
Fillarray(array);// заполнил массив
PrintArray(array);// Напечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
