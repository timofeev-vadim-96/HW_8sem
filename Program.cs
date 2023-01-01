
void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + '\t');
        }
        System.Console.WriteLine();
    }
}



int [,] basicArray = new int [4,4];

// System.Console.WriteLine("Введите через пробел: с какого числа будем заполнять нашу матрицу и с каким шагом? ");
// string [] firstArray = (Console.ReadLine().Split(" "));
// int step = Convert.ToInt32(firstArray[1]);
// void SpiralFilling (int [,] inputArray)
// {
//     inputArray[0,0] = Convert.ToInt32(firstArray[0]);
//     for (int j = 1; j < inputArray.GetLength(1); j++)
//     {
//         inputArray[0,j] = inputArray[0,j-1] + step;
//     }
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Матрица, заполненная по спирали: ");
// SpiralFilling(basicArray);
PrintMatrix(basicArray);