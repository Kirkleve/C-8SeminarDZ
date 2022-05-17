/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int lines = InputNumber("Введите кол-то строк");
int colomns = InputNumber("Введите кол-во столбцов");
int[,] array = new int[lines, colomns];
FillArray(array, 1, 10);
PrintArray(array);

int[,] minValue = MinValue(array);

PrintArray(minValue);







int InputNumber(string output)
{
    Console.Write(output + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] matr, int festNumber, int secondNumber)
{
    for (int lines = 0; lines < matr.GetLength(0); lines++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[lines, columns] = new Random().Next(festNumber, secondNumber);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($" {matrix[rows, columns]}");
        }
        Console.WriteLine();
    }
}

int[,] MinValue(int[,] array)
{
    int x = 0;
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int[,] minValue = new int[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minValue[i,j] > array[i, j])
            {
                newArray[x,x] = array[i, j];
                x++;

            }    
        }
        
    }
    return newArray; 
}

int[,] DeleteRow(int[,] array, int row)
        {
            int[,] result = new int[array.GetLength(0)-1, array.GetLength(1)];
            int x = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == row)
                {
                    row = -1;
                    continue;
                }
 
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[x, j] = array[i, j];
                }
                x++;
            }
            return result;
        }

int[,] DeleteColomns(int[,] array, int col)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)-1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int x = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == col)continue;
                    result[i, x] = array[i, j];
                    x++;
                }
            }
            return result;
        }