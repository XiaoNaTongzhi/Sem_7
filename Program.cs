// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными целыми числами.

// Console.Write($"Количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write($"Количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] matrix47 = GetArrayMN(rows, columns);
// PrintMatrix(matrix47);

// int[,] GetArrayMN(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10, 100);
//         }
//     }
//     return array;
// }





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// 1. ПРОСТОЙ СПОСОБ:

// int[,] matrix1 = RandomMatrix();

// Console.Write($"Строка: ");
// int rowIndex = int.Parse(Console.ReadLine()!) - 1; // обыватели считают с единицы :)

// Console.Write($"Столбец: ");
// int columnIndex = int.Parse(Console.ReadLine()!) - 1;

// // то, что вводим, на единицу больше индекса, поэтому "или равно"
// if ((rowIndex >= matrix1.GetLength(0) && columnIndex >= matrix1.GetLength(1)) ||
//     (rowIndex >= matrix1.GetLength(0) || columnIndex >= matrix1.GetLength(1)))
// {
//     Console.Write("Вы за пределами матрицы.");
// }
// else 
// {
//     Console.WriteLine($"Число найдено: {matrix1[rowIndex, columnIndex]}");
// }



// 2. МАНЬЯЧНЫЙ СПОСОБ:

// int[,] matrix2 = RandomMatrix();

// Console.Write($"Введите номер искомого числа в строке: "); // т. е. номер столбца
// int columnIndex = int.Parse(Console.ReadLine()!) - 1; // обыватели считают с единицы :)
// Console.Write($"Введите номер искомого числа в столбце: ");// т. е. номер строки
// int rowIndex = int.Parse(Console.ReadLine()!) - 1;


// if (rowIndex >= matrix2.GetLength(0) && columnIndex >= matrix2.GetLength(1))
// {
//     Console.WriteLine($"Число должно быть в {rowIndex + 1}-й строке и в {columnIndex + 1}-м столбце, в матрице их нет :)");
// }

// else if (rowIndex >= matrix2.GetLength(0))
// {
// Console.WriteLine($"Число должно быть в {rowIndex + 1}-й строке, а в матрице всего {matrix2.GetLength(0)} :)");
// }

// else if (columnIndex >= matrix2.GetLength(1))
// {
//    Console.WriteLine($"Число должно быть в {columnIndex + 1}-м столбце, а в матрице всего {matrix2.GetLength(1)} :)"); 
// }
// else 
// {
// Console.WriteLine($"Число найдено: {matrix2[rowIndex, columnIndex]}");
// };



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


// 0 - номер строки = индекс в столбце q
// 1 - номер столбца = индекс в строке d


// Console.WriteLine(); // отступ
// int[,] matrix52 = RandomMatrix();
// Console.WriteLine(); // отступ
// int sum = 0;
// int arith = 0;
// for (int d = 0; d < matrix52.GetLength(1); d++)
// {
//     for (int q = 0; q < matrix52.GetLength(0); q++)
//     {
//         sum += matrix52[q, d];
//     }
//     arith = sum / matrix52.GetLength(0);
//     Console.WriteLine($"Сумма элементов {d + 1}-го столбца -> {sum} ");
//     Console.WriteLine($"Среднее арифметическое элементов {d + 1}-го столбца -> {arith} ");
//     Console.WriteLine();
//     sum = 0;
//     arith = 0;
// }





// МЕТОДЫ

// МАТРИЦА СЛУЧАЙНОГО РАЗМЕРА

int[,] RandomMatrix()
{
    int rows = new Random().Next(3, 6);
    int columns = new Random().Next(3, 10);

    int[,] randomMatrix = GetMatrix(rows, columns);

    Console.WriteLine($"Строк: {rows}. Столбцов: {columns}. Ваша матрица:");
    PrintMatrix(randomMatrix);

    return randomMatrix;
}


// ЗАПОЛНЕНИЕ МАТРИЦЫ (на ввод: количество строк и столбцов)

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int m = 0; m < rows; m++)
    {
        for (int w = 0; w < columns; w++)
        {
            matrix[m, w] = new Random().Next(10, 100);
        }
    }
    return matrix;
}

// ВЫВОД МАТРИЦЫ


void PrintMatrix(int[,] arr)
{
    for (int b = 0; b < arr.GetLength(0); b++)
    {
        for (int p = 0; p < arr.GetLength(1); p++)
        {
            Console.Write($"{arr[b, p]} ");
        }
        Console.WriteLine();
    }
}





// _____________________________________________________________________________________
// С СЕМИНАРА

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Console.Write($"Количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write($"Количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] newArray = GetArray(rows, columns);
// PrintArray(newArray);

// for (int x = 0; x < newArray.GetLength(0); x++)
// {
//     for (int y = 0; y < newArray.GetLength(1); y++)
//     {
//         if (x % 2 == 0 && y % 2 == 0)
// {
//     newArray[x, y] = newArray[x, y] * newArray[x, y];
// }
//     }
// }



// PrintArray(newArray);

// int[,] GetArray(int m, int n)
// {
//     int[,] array = new int[m, n];



//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }


// void PrintArray(int[,] arr)
// {
//       for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//            Console.Write($"{arr[i, j]} ");
//         }

//        Console.WriteLine();
//     }
// }





// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.







// **Задача 48:** Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.


// Console.Write($"Количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write($"Количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] newArray = GetArrayMN(rows, columns);
// PrintMatrix(newArray);

// int[,] GetArrayMN(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

