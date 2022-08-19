// Дан массив из 10 целых чисел в диапозоне от [-99,60] заменить в этом массиве отрицательные числа на 0
void FillArray(int[] collection, int minimum, int maximum)
{
    int index = 0;
    var random = new Random();
    while (index < collection.Length)
    {
        collection[index] = random.Next(minimum, maximum+1);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
{
    Console.Write(col[position] +" ");
    position++;
}
}

void ReArray(int[] replacement)
{
    int length = replacement.Length;
    int index = 0;
    while (index < length)
    {
        if (replacement[index] < 0)
        {
            replacement[index]=0;
        }
        index++;
    }
}

int[] array = new int[10];
FillArray(array, -99, 60);
PrintArray(array);
Console.WriteLine(" ");
ReArray(array);
PrintArray(array);
