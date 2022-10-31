// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы: ");
int rnd1 = InputNumbers("Введите верхний диапазон случайных чисел: ");

int[,] Martrix1 = new int[m, n];
CreateArray(Martrix1);
Console.WriteLine($"Вот первая матрица:");
WriteArray(Martrix1);

int[,] Martrix2 = new int[n, p];
CreateArray(Martrix2);
Console.WriteLine($"Вот вторая матрица:");
WriteArray(Martrix2);

int[,] Matrix3 = new int[m,p];

MultiplyMatrix(Martrix1, Martrix2, Matrix3);
Console.WriteLine($"Вот произведение матриц:");
WriteArray(Matrix3);

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] Matrix3)
{
  for (int i = 0; i < Matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < Matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      Matrix3[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(rnd1);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}