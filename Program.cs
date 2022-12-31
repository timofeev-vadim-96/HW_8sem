// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] GetMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void ArrangeStrokes (int [,] array)
{
    int [] array2 = new int [array.GetLength(0)];
    int min = int.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i] = array2[i] + array[i,j];
        }
        if (min>array2[i])
        {
            min = array2[i];
            minIndex = i;
        }
    } 
    System.Console.WriteLine($"номер строки с наименьшей суммой элементов: {minIndex+1} строка");
}
void PrintMatrix(int [,] InputMatrix)
{
    for (int i = 0; i < InputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InputMatrix.GetLength(1); j++)
        {
            System.Console.Write(InputMatrix[i,j] + "\t");
        }    
        System.Console.WriteLine();    
    }
}
System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] result = GetMatrix(rows, columns);
System.Console.WriteLine("Базовый двумерный массив");
PrintMatrix(result);
System.Console.WriteLine();
ArrangeStrokes(result);





