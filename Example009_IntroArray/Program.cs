int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//             0, 1, 2, 3, 4, 5, 6, 7, 8
int[] array = {21,32,34,54,15,610,17,80,19};
// array[0] = 12; // меняем значение с 21 на 12 в массиве с элементом с индексом 0 
// Console.WriteLine(array[0]);
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);


