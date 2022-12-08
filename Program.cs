// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
Console.WriteLine("=================================== ");
GetSortRows(array);
PrintArray(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}


void GetSortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool flag = true;
        while (flag)
        {
            flag = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    flag = true;
                }
            }
       }
    }
}
*/



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
Console.WriteLine("=================================== ");


int minSumRow = 0;
int sumRow = MinSumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = MinSumRows(array, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}


Console.Write($"Строкa с наименьшей суммой элементов -> ");
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"{array[minSumRow, i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов = {sumRow}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}


int MinSumRows(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк второй матрицы: ");
int p = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int r = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = GetArray(m, n, 0, 9);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = GetArray(p, r, 0, 9);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[n,r];
if (n == p)
{
ProizvMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение матриц:");
WriteArray(resultMatrix);
}
else Console.WriteLine("Такие матрицы не умножаются!");



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
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

void ProizvMatrix (int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


