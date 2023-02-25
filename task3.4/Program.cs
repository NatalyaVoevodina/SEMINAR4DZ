//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-100,100);
}
Console.WriteLine(string.Join(", ", arr));