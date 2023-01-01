// Сломал себе мозг по сравнению всех элементов трехмерного массива, но сделал. В данной программе вы 
// гарантированно получите неповторяющиеся элементы двухзначных чисел (использована рекурсия)

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
                matrix3d[i,j,k] = new Random().Next(10,18);
           } 
        }
    }
    return matrix3d;
}
void Abrakadabra (int [,,] array)// метод для замены одинаковых элементов чисел.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int temp = array [i,j,k];//берем по одному значению из массива для сравнения
                for (int l = 0; l < array.GetLength(0); l++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        for (int n = 0; n < array.GetLength(2); n++)
                        {
                            if (i==l && j== m && k==n) continue;
                            else if (temp == array [l,m,n]) 
                            {
                            array[l,m,n] = new Random().Next(10,18);
                            Abrakadabra (array);//На случай, если новое число будет = одному из тех, которые уже имеются
                            }
                        }
                    }
                }
            }
        }
    }
} 
System.Console.WriteLine();
System.Console.WriteLine("Базовая трехмерная матрица: ");
int [,,] resultMatrix = Fill3dMatrix(matrix);
PrintMatrix(resultMatrix);
Abrakadabra(resultMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Трехмерная матрица c неповторяющимися двузначными числами: ");
PrintMatrix(resultMatrix);
System.Console.WriteLine();
