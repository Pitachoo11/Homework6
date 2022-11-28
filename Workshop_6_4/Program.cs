// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillArray(int[] array)
{
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
}

int[] CopyArray(int[] array)
{
    int[] copyOfArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        copyOfArray[i] = array[i];

    return copyOfArray;
}

int[] a = new int[10];
FillArray(a);
System.Console.WriteLine(String.Join(", ", CopyArray(a)));