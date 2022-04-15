// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Number = getNumber();
string unswer = Analyze(Number);
Console.WriteLine(unswer);

int getNumber()
{
Console.Write("Введите порядковый номер дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());
return Number;
}

string Analyze(int Number)
{
    string unswer;
    if(Number < 6)
    {
        unswer = "Нет";
    }
    else if (Number < 8)
    {
        unswer = "Да";
    }
    else
    {
        unswer = "Неверный порядковый номер дня недели";
    }
    return unswer;
}
