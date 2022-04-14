// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int Input = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(Input); 

if (Number.Length < 3)
{
    Console.Write("Третьего числа нет");
}
else
{
    Console.Write("Третье число " + Number[2]);
}
