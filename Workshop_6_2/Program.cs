// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//получает обратную запись двоичного числа из дсятичного
int ConvertToBinary(int inputNumber)
{
    int reversedBinNumber = 0;
    List<int> s = new List<int>(); //Определение ДИНАМИЧЕСКОГО массива
    while(inputNumber > 0)
    {
        reversedBinNumber = inputNumber % 2;
        inputNumber = inputNumber / 2;
        s.Add(reversedBinNumber);
    }
    return BinaryReverse(s);
}
//переворачивает число и возвращает прямую запись двоичного числа.
int BinaryReverse(List<int> norm)
 {
    int[] binaryArray = new int[norm.Count];
    for (int i = norm.Count-1; i >= 0 ; i--)
    {
        binaryArray[norm.Count -1 -i] = norm[i];
    }
    return Convert.ToInt32(string.Join<int>("",binaryArray));
}

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBinary(number));


