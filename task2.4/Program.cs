//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int n = N;
while (n != 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine($"Сумма цифр числа {N} = {sum}");