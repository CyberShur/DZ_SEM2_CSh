// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

string Number = newNumber();
string Result = Definition(Number);
Console.Write(Result);

string newNumber()
{
    Console.Write("Введите трёхзначное число: ");
    string Number = Console.ReadLine();
    Convert.ToInt32(Number);
    return Number;
}


string Definition(string Number)
{
    string Result;
    if (Number.Length < 3)
    {
        Result = "Число не трёхзначное";
    }
    else if (Number.Length == 3)
    {
        Result = "Второе число - " + Number[1];
    }
    else
    {
        Result = "Число не трёхзначное";
    }
    return Result;
}