// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты");
int x1 = Cordinat("x", "A");
int y1 = Cordinat("y", "A");
int z1 = Cordinat("z", "A");
int x2 = Cordinat("x", "B");
int y2 = Cordinat("y", "B");
int z2 = Cordinat("z", "B");

int Cordinat(string NameOfCor, string NameOfPoint)
{
    Console.WriteLine($"Введите коордитнату {NameOfCor} точки {NameOfPoint}: ");
    return Convert.ToInt16(Console.ReadLine());

}

double Decision(double x1, double x2,
double y1, double y2,
double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) +
                     Math.Pow((y2-y1), 2) +
                     Math.Pow((z2-z1), 2));

}
double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");