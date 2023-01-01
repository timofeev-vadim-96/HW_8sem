// Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
// Все-таки как-то сделал сам УНИВЕРСАЛЬНУЮ ПРОГРАММУ ДЛЯ МАТРИЦЫ ЛЮБОГО РАЗМЕРА!
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

System.Console.WriteLine("Введите через пробел размер матрицы: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A<2) //Прервывание на случай, если значение, введенное с клавиатуры менее 2
{
    System.Console.WriteLine("Матрица не может быть размером, менее 2");
    return;
}
int [,] basicArray = new int [A,A];

System.Console.WriteLine("Введите через пробел: с какого числа будем заполнять нашу матрицу и с каким шагом? ");
string [] firstArray = (Console.ReadLine().Split(" ")); // Воспользовался новым способом считывать сразу несколько
// значений с клавиатуры, что-то новое)
int step = Convert.ToInt32(firstArray[1]); // значение шага, с которым будут изменяться значения цифр
int Numb = Convert.ToInt32(firstArray[0]);
void SpiralFilling (int [,] inputArray) // заполняем матрицу (УНИВЕРСАЛЬНЫЙ МЕТОД! ПОЛУЧИЛОСЬ!)
{
    for (int count = 0; count < (A/2+A%2); count++)
    {
        if (count ==0 ) inputArray[0,0] = Numb; //стартовая позиция, откуда начнем заполнять
        for (int j = 0+count; j < inputArray.GetLength(1)-count; j++) //заполняем первую строку, начиная со 2+count значения
        {
            if (j==0) j=1; //если это первое значение
            inputArray[0+count,j] = Numb + step;
            Numb = inputArray[0+count,j];// число запоминает свой рост в предыдущем действии для следующих операций с ним
        }
        for (int i = 1+count; i < inputArray.GetLength(0)-count; i++) //заполняем правый столбец, начиная со 2+count значения
        {
            inputArray[i,inputArray.GetLength(1)-1-count] = Numb + step;
            Numb = inputArray[i,inputArray.GetLength(1)-1-count];
        }
        for (int j = inputArray.GetLength(1)-2-count; j >= 0+count; j--) //заполняем нижнюю строчку, начиная со 2+count значения с КОНЦА
        {
            inputArray[inputArray.GetLength(0)-1-count,j] = Numb + step;
            Numb = inputArray[inputArray.GetLength(0)-1-count,j];
        }
        for (int i = inputArray.GetLength(0)-2-count; i > 0+count; i--) //заполняем левый столбец, начиная со 2+count СНИЗУ
        {
            inputArray[i,0+count] = Numb + step;
            Numb = inputArray[i,0+count];
        }
    }
    
}

System.Console.WriteLine();
System.Console.WriteLine("Матрица, заполненная по спирали: ");
SpiralFilling(basicArray);
PrintMatrix(basicArray);