// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] ProductOfMatrices (int [,] FirstMatrix, int [,] SecondMatrix)
{
    int [,] ResultMatrix = new int [FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ResultMatrix.GetLength(0); k++)
            {
                ResultMatrix[i,j] += (FirstMatrix[i,k] * SecondMatrix[k,j]) ;
            }
        }
    }
    return ResultMatrix; 
}

int [,] matrix1 = new int [,] {{2,4},{3,2}};
int [,] matrix2 = new int [,] {{3,4},{3,3}};
System.Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);

System.Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);
System.Console.WriteLine();

System.Console.WriteLine("Результирующая матрица: ");
int [,] resMatr = ProductOfMatrices(matrix1,matrix2);
PrintMatrix(resMatr);






