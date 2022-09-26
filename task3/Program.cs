// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// метод ввода колличества строк  в массив
int line2DArray()
{
    Console.Write("Введите колличество строк в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return line2DArray();
    }
    else
    {
        return line;
    }
}

// метод ввода колличества столбцов в массив
int column2DArray()
{
    Console.Write("Введите колличество столбцов в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int column);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return column2DArray();
    }
    else
    {
        return column;
    }
}

// метод создания массива двухмерного 
int[,] make2DArray()
{
    int line = line2DArray();
    int column = column2DArray();
    int[,] array = new int[line, column];
    return array;
}

// метод ввода отрезка рандомных цифр от .
int randomNumbersStart()
{

    Console.Write("Введите начало отрезка рандомных цифр для заполнения массива: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return randomNumbersStart();
    }
    else
    {
        return start;
    }

}
// метод ввода отрезка рандомных цифр до .
int randomNumbersEnd()
{
    Console.Write("Введите конец отрезка рандомных цифр для заполнения массива: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return randomNumbersEnd();
    }
    else
    {
        return finish;
    }
}

// метод заполнения двухмерного массива.
int[,] fill2DArray(int[,] array, int startRandom, int finishRandom)
{
    Random random = new Random();
    int startValue = startRandom;
    int endValue = finishRandom;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = random.Next(startValue, endValue);
        }
    }
    return array;
}

// метод вывода массива в консоль
void write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Среднее арифметическое каждого столбца:
string arithmeticMeanOfElements(int[,] array)
{
    string result = string.Empty;
    double count = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

        {
            count = count + array[j, i];
        }

        count = count / array.GetLength(0);
        if (i == (array.GetLength(1) - 1)) result = result + count + ".";
        else result = result + count + "; ";
        count = 0;
    }
    return result;
}

//cделали массив
int[,] array = make2DArray();
// получили рандомные числа
int startRandom = randomNumbersStart();
int finishtRandom = randomNumbersEnd();
// заполнили массив 
array = fill2DArray(array, startRandom, finishtRandom);
// вывели массив
write2DArray(array);
Console.WriteLine();
string result = arithmeticMeanOfElements(array);
Console.WriteLine($"Среднее арифметическое каждого столбца : {result}");