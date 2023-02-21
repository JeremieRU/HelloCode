void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // если в ответе будет -1, то это можно интерпретировать как то, что такой элемент не найден

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;                  //так найдёт первое совпадение
        }
        index++;
    }
    return position;        //так найдёт последнее совпадение если убрать break
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 44);
Console.WriteLine(pos);