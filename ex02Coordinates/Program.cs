// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadNumber(string mes)
{
    Console.Write(mes+": ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
Console.WriteLine("Введите координаты первой точки:");
int x1 = ReadNumber("X");
int y1 = ReadNumber("Y");
int z1 = ReadNumber("Z");
Console.WriteLine("Введите координаты второй точки:");
int x2 = ReadNumber("X");
int y2 = ReadNumber("Y");
int z2 = ReadNumber("Z");
int x = (x2-x1)*(x2-x1);
int y = (y2-y1)*(y2-y1);
int z = (z2-z1)*(z2-z1);
double S = Math.Pow((x+y+z), (1.0/2.0));
string result = String.Format("{0:f2}", S);
Console.WriteLine($"Расстояние между двумя точками равняется {result}.");