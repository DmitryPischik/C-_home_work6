// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray(double[,] matr) // функция просматривает массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
    Console.WriteLine();
    }
}
void FillArray(double[,] matr) // функция заполняет массив.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble() * 100;
        }
    }
}
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);
