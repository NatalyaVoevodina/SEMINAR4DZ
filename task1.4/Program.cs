// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void ToDegree(int a, int b) // Функция возведения в степень
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    
    Console.WriteLine(a + " в "+ b +" степени = " + res);
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int step = Convert.ToInt32(Console.ReadLine());
ToDegree(N, step);