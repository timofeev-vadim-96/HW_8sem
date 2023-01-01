// Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
// Все-таки как-то сделал сам задачку)
void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int [,] basicArray = new int [4,4];

System.Console.WriteLine("Введите через пробел: с какого числа будем заполнять нашу матрицу и с каким шагом? ");
string [] firstArray = (Console.ReadLine().Split(" ")); // Воспользовался новым способом считывать сразу несколько
// значений с клавиатуры, что-то новое)
int step = Convert.ToInt32(firstArray[1]); // значение шага, с которым будут изменяться значения цифр
int Numb = Convert.ToInt32(firstArray[0]);
void SpiralFilling (int [,] inputArray) // заполняем матрицу (не универсальный метод, работает только для 4х4)
{
    inputArray[0,0] = Numb; //стартовая позиция, откуда начнем заполнять
    for (int j = 1; j < inputArray.GetLength(1); j++) //заполняем первую строку, начиная со 2 значения
    {
        inputArray[0,j] = Numb + step;
        Numb = inputArray[0,j];// число запоминает свой рост в предыдущем действии для следующих операций с ним
    }
    for (int i = 1; i < inputArray.GetLength(0); i++) //заполняем правый столбец, начиная со 2 значения
    {
        inputArray[i,inputArray.GetLength(1)-1] = Numb + step;
        Numb = inputArray[i,inputArray.GetLength(1)-1];
    }
    for (int j = inputArray.GetLength(1)-2; j >= 0; j--) //заполняем нижнюю строчку, начиная со 2 значения с конца
    {
        inputArray[inputArray.GetLength(0)-1,j] = Numb + step;
        Numb = inputArray[inputArray.GetLength(0)-1,j];
    }
    for (int i = inputArray.GetLength(0)-2; i > 0; i--) //заполняем левый столбец, начиная со 2 снизу
    {
        inputArray[i,0] = Numb + step;
        Numb = inputArray[i,0];
    }
    for (int j = 1; j < inputArray.GetLength(1)-1; j++) //заполняем вторую строку
    {
        inputArray[1,j] = Numb + step;
        Numb = inputArray[1,j];
    }
    for (int j = inputArray.GetLength(0)-2; j > 0; j--) //заполняем третью строку
    {
        inputArray[2,j] = Numb + step;
        Numb = inputArray[2,j];
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Матрица, заполненная по спирали: ");
SpiralFilling(basicArray);
PrintMatrix(basicArray);