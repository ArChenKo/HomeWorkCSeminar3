// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int ReadNumber(string mes)
{
    Console.Write(mes + ": ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
int a = ReadNumber("Введите число");
int num = 1;
int cube = 0;
Console.WriteLine("N | N в кубе");
while (num <= a)
{
    cube = num * num * num;
    Console.WriteLine(num + " | " + cube);
    num++;
}