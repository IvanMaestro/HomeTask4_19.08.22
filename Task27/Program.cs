// Задача 27: Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum (int num)
{
int sum = 0;
int tempDigit1 = 0;
int tempDigit2 = num;

for (; tempDigit2 > 0; )
{
    tempDigit1 = tempDigit2 % 10;
    sum = sum + tempDigit1;
    tempDigit2 = tempDigit2 / 10;
}
return sum;
}
int result = DigitSum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");