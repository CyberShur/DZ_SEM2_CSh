// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string Numbers = Convert.ToString(Number); 

if (Numbers.Length < 3)
{
    Console.Write("Число не трёхзначное");
}
else if (Numbers.Length == 3)
{
    Console.Write("Второе число - " + Numbers[1]);
}
else
{
    Console.Write("Число не трёхзначное");
}
