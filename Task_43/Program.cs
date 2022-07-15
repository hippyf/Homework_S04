/* Программа, котораая найдёт точку пересечения двух прямых,
заданных уравнением y = k1*x + b1; y = k2*x + b2. Значения k1, b1, k2, b2
задаются пользователем */

Task43();

void Task43 ()
{
    Console.WriteLine("Введите координаты для первой прямой: k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты для второй прямой: k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    CrossPoint (k1, b1, k2, b2);
}

void CrossPoint (double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;
    Console.WriteLine("Точка пересечения двух прямых ходится по координатам: x = " + x + " y = " + y);
}

