// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void FindCoordinates()
{
    Console.WriteLine("Введите значения переменных:");
    Console.Write("k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    if (k1 == k2) Console.WriteLine("Прямые параллельны.");
    else
    {
        double x = (b2 - b1) / (k1 -k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения заданных прямых - ({x}; {y}).");
    }
}



FindCoordinates();