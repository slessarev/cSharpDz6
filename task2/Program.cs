// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Parameterinput(string text)
{
    Console.Write(text);
    int parameter = int.Parse(Console.ReadLine());
    return parameter;
}

void IntersectionPoints(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны.");
    else
    {

        double pointX = (b2 - b1) / (k1 - k2);
        double pointY = k1 * pointX + b1;
        Console.WriteLine($"Координата точки пересечения прямых: ({pointX}; {pointY})");
    }
}

Console.Clear();
int b1 = Parameterinput("Введите b1: ");
int k1 = Parameterinput("Введите k1: ");
int b2 = Parameterinput("Введите b2: ");
int k2 = Parameterinput("Введите k2: ");
IntersectionPoints(b1, k1, b2, k2);