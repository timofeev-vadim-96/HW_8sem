// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix(int [,,] InputMatrix)
{
    for (int i = 0; i < InputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < InputMatrix.GetLength(2); k++)
            {
                System.Console.Write($"{InputMatrix[i,j,k]}({i},{j},{k}) ");
            }
        } 
        System.Console.WriteLine();    
    }
}


int [,,] matrix = new int [2,2,2];

int [,,] Fill3dMatrix (int [,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
           for (int k = 0; k < matrix3d.GetLength(2); k++)
           {
                matrix3d[i,j,k] = new Random().Next(1,10);
           } 
        }
    }
    return matrix3d;
}
System.Console.WriteLine();
System.Console.WriteLine("Трехмерная матрица: ");
int [,,] resultMatrix = Fill3dMatrix(matrix);
PrintMatrix(resultMatrix);
System.Console.WriteLine();









