// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int ReadNumber(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
bool PlaceNum(int number)
{
    int a = number / 10000;
    int b = number / 1000 % 10;
    int c = number / 10 % 10;
    int d = number % 10;
    if (a == d && b == c)
    {
        return true;
    }
    return false;
}
int number = ReadNumber("Введите пятизначное число: ");
while (number < 10000 | number > 99999)
    number = ReadNumber("Число должно состоять из пяти цифр, попробуйте еще раз: ");
if (PlaceNum(number))
    Console.WriteLine($"Введенное число {number}, без сомнения, является палиндромом.");
else
    Console.WriteLine($"Введенное число {number} палиндромом, увы, не является.");