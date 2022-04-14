// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

int Number = new Random().Next(1, 11);
int Gamer = Convert.ToInt32(Console.ReadLine());


while (Gamer != Number)
{
    Console.Write("Увы! Попробуй ещё раз!");
    int Gamer = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Ваша интуиция вас не подвела! Это число: ");



// if(Gamer == Number)
// {
//    Console.Write("Ваша интуиция вас не подвела! Это число: ");
//}
//else
//{
//    Console.Write("Увы! Попробуй ещё раз!");
//}


// Console.Write(Number);