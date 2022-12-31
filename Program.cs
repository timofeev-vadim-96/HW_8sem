// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void FillArray (int [,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            InputArray[i,j] = new Random().Next(1,10);
        }
    }
}

void OrganizeArray (int [,] InputArray)
{
    int temp = 0;
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            for (int k = 0; k < InputArray.GetLength(1); k++)
            {
                if (InputArray[i,j] > InputArray[i,k])
                {
                    temp = InputArray[i,j];
                    InputArray[i,j] = InputArray[i,k];
                    InputArray[i,k] = temp;
                }
            }
        }
    }
}

System.Console.WriteLine("Введите количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,columns];
System.Console.WriteLine("Исходный двумерный массив: ");
FillArray(array);
PrintMatrix(array);
System.Console.WriteLine("Упорядоченный двумерный массив: ");
OrganizeArray(array);
PrintMatrix(array);







