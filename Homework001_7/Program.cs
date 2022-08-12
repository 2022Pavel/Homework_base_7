/*Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

double[,] a = new double[3, 4];

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.NextDouble()*100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,9:F2}", a[i, j]);
    }
    Console.WriteLine();
}
