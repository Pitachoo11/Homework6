// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System.Linq;

void CountPositiveNumbers(string data)
{
   int[] InputArray = Array.ConvertAll(data.Replace(" ", "").Split(","), int.Parse);
   int count = InputArray.Count(x => x > 0);
   Console.WriteLine($"Кол-во элементов > 0: {count}");
}

Console.WriteLine("Введите произвольное количество целых чисел, разделенных запятой:");
string data = Console.ReadLine();

CountPositiveNumbers(data);