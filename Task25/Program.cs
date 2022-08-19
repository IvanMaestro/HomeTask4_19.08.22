// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите, в какую степень возвести число: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = b;
int result = a;

for (int i = 1; i < b; i++)
{
    result = result * a;
}
int pow = result;
Console.WriteLine($"{a} в {b} степени = {pow}");
