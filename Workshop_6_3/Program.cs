// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();
int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

int input = GetIntFromConsole("Enter N = ");

int number1 = 0;
int number2 = 1;
int summ = 0;
string result = "0 1";

for (int i = 1; i < input - 1; i++)
{
    summ = number1 + number2;
    result += " " + summ.ToString();
    number1 = number2;
    number2 = summ;
}

WriteLine(result);