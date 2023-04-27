/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//double k1, k2, b1, b2;

double InPutNum(string line)
{
    Console.WriteLine(line);
    return double.Parse(Console.ReadLine());
}

/* k1 = InPutNum("Insert k1");
k2 = InPutNum("Insert k2");
b1 = InPutNum("Insert b1");
b2 = InPutNum("Insert b2");
 */

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Точек пересечения нет, прямые параллельрны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("Координаты точек пересечения: " + (y, x));
    }
}

IntersectionPoint(InPutNum("Insert k1"),InPutNum("Insert b1"),InPutNum("Insert k2"),InPutNum("Insert b2"));

