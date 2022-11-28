// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CheckTriangle(int A, int B, int C)
{
    return (A + B > C && A + C > B && B + C > A);
    
}
Console.Write("Длина отрезка 1: ");
int section1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Длина отрезка 2: ");
int section2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Длина отрезка 3: ");
int section3 = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle (section1, section2,section3) == true)
{
    Console.WriteLine("Да, Треугольник со сторонами такой длины существует");
}
else
{
    Console.WriteLine("Нет, Треугольник со сторонами такой длины НЕ существует");
}
