// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Введите первое число число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 * number1 == number2)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

// int number = int.Parse(Console.ReadLine());
// int sqr = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {sqr}");