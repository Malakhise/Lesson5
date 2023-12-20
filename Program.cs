
// Задача 3:Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// using System.Numerics;

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(0, 10);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void SumMatrix(int[,] matrix)
// {
//     int[] sum = new int[matrix.GetLength(0)];
//   int summa;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//         summa = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             summa += matrix[i,j]; 
// Console.Write($"{summa} ");
//   } 
   
//    // Console.WriteLine(summa);
// }

// void RelisMatrix(int[,] matrix)
// {
//     int max;
//    for (int i = 0; i < matrix.Length; i++)
//        int max = matrix[0]; 
//       {
//         if (matrix[i] > max);
//         max = matrix[i];
//       }
// Console.Write($"{max} ");
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// SumMatrix(matrix);
// RelisMatrix(matrix);
//---------------------------------------------------------------------------------------
// Урок 5
// Задача 3; Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0,10);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }
// int m = InputNumbers("Введите m");
// int n = InputNumbers("Введите n");


// int[,] array = new int[m,n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }
// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }
// ----------------------------------------------------------------------------------------------------------------
// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // [2, 5]
int[,] matrix = new int[size[0], size[1]];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

InputMatrix(matrix);
PrintMatrix(matrix);

   for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var tmp = matrix[matrix.GetLength(1) - 1, i];
                matrix[matrix.GetLength(1) - 1, i] = matrix[0, i];
                martix[0, i] = tmp;
            }
 
            Console.WriteLine("\nИзмененный массив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();

//    ﻿// Задача 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arr = FillMatrixRnd(m, n);
// PrintMatrix(arr);
// FindElement(arr);

// // Заполнение массива случайными числами
// int[,] FillMatrixRnd(int row, int col)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return matrix;
// }

// // Вывод двумерного массива
// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Вывод элемента массива по заданным пользователем номеру строки и столбца (не индексам)
// void FindElement(int[,] matrix)
// {
//     Console.Write("Введите номер строки искомого элемента: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца искомого элемента: ");
//     int col = Convert.ToInt32(Console.ReadLine());
//     if (row > matrix.GetLength(0)
//         || row - 1 < 0
//         || col > matrix.GetLength(1)
//         || col - 1 < 0)
//     { Console.WriteLine("Такой позиции нет в массиве."); }
//     else
//     { Console.WriteLine($"\nИскомый элемент: {matrix[row - 1, col - 1]}"); }
// }  