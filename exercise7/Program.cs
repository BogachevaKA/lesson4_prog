//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");
ToDegree(number, degree);
void ToDegree(int num, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= num;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}