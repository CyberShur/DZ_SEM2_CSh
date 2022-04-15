// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, 
// больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

int Number = new Random().Next(1, 10);
Console.WriteLine("Я хочу сыграть в игру. Тут загадано число от 1 до 9. Угадаете его за три попытки?");

int Gamer = 0; 
int count = 0;

while(Gamer != Number)
{
    Console.Write("Введите число: ");
    Gamer = Convert.ToInt32(Console.ReadLine());
    if(Gamer == Number)
    {
        Console.Write("Ваша интуиция вас не подвела! Это число: " + Number);
    }
    else if (count < 2)
    {
        Console.WriteLine("Мимо!");
        if(Gamer > Number)
        {
            Console.WriteLine("Ваше число больше того, что я загадал");
        }
        else
        {
            Console.WriteLine("Ваше число меньше того, что я загадал");
        }    
        count++;
    }
    else
    {
        Console.WriteLine("Попытки закончились. Вы проиграли!");
        break;
    }
}
