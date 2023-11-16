// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// пользователь вводит b1,k1, b2,k2
// k1*x+b1=k2*x+b2;
// k1*x-k2*x=b2-b1;
// x(k1-k2)=b2-b1;
// x=(b2-b1)/(k1-k2);

// y=k1*((b2-b1)/(k1-k2))+b1;

double Input(string msg)
{
    Console.Write(msg);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double b1, double b2, double k1, double k2)
{
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return y;
}

bool ValidateCoord(double k1, double k2)
{
    if (k1 == k2)
    {
        return false;
    }
    return true;
}


double b1 = Input("Введите b1: ");
double k1 = Input("Введите k1: ");
double b2 = Input("Введите b2: ");
double k2 = Input("Введите k2: ");
if (ValidateCoord(k1, k2))
{
    Console.WriteLine($"({FindX(b1, b2, k1, k2)};{FindY(b1, b2, k1, k2)})");
}
else
{
    Console.WriteLine("Прямые параллельны :)");
}