// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


int[,,] matrix3D = new int[2, 2, 2];


for (int i = 0; i < matrix3D.GetLength(0); i++)
{
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
        for (int y = 0; y < matrix3D.GetLength(2); y++)
        {
            int n = new Random().Next(10, 100);
            for (int a = 0; a < i * j * y; a++)
            {
                void GetNumber()
                {
                    if (n == matrix3D[i, j, y])
                    {
                        GetNumber();
                    }
                    else matrix3D[i, j, y] = n;
                }
            }
        }
    }
}

for (int i = 0; i < matrix3D.GetLength(0); i++)
{
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
        for (int y = 0; y < matrix3D.GetLength(2); y++)
        {
            Console.WriteLine($"{matrix3D[i, j, y]} ({i}, {j}, {y})  ");
        }
    }
}
