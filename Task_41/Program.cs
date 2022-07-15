/* Пользователь вводит с клавиатуры М чисел. 
Посчитать, сколько чисел больше 0 ввёл пользователь */

Task41();

void Task41 ()
{
    Console.WriteLine("Сколько чисел будете вводить?");
    int count = Convert.ToInt32(Console.ReadLine());
    CountOfPositiveNum (count);
}

void CountOfPositiveNum (int count)
{
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine("Введите " + i + " число");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) result += 1;
    }
    Console.WriteLine("Вы ввели " + result + " чисел больше 0");
}