// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string Number = InputNumber();
string Result = Examination(Number);
Console.WriteLine(Result);

string InputNumber()
{
    Console.Write("Введите число: ");
    string Number = Console.ReadLine();
    Convert.ToInt32(Number);
    return Number;
}

string Examination(string Number)
{
    string Result;
    if (Number.Length < 3)
    {
        Result = "Третьего числа нет";
    }
    else
    {
        Result = "Третье число - " + Number[2];
    }
    return Result;
}