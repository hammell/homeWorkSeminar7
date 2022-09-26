// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// метод ввода колличества строк  в массив
int inStingArray()
{
    Console.Write("Введите колличество строк массива: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено не корректное значение");
        return inStingArray();
    }
    else
    {
        return line;
    }
}

// метод ввода колличества столбцов в массив
int inColumnsArray()
{
    Console.Write("Введите колличество столбцов массива: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int column);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено не корректное значение");
        return inColumnsArray();
    }
    else
    {
        return column;
    }
}

// метод создания массива двухмерного 
int[,] make2DArray()
{
    int line = inStingArray();
    int column = inColumnsArray();
    int[,] array = new int[line, column];
    return array;
}

// метод ввода отрезка рандомных цифр от .
int randomNumbersStart()
{

    Console.Write("Введите первое значение отрезка рандомных цифр: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено не корректное значение");
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
    Console.Write("Введите последнее значение отрезка рандомных цифр: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено не корректное значение");
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

// поиск по позициям элемента в двухмерном массиве
string FindNumber(int line, int column, int[,] array)
{
    string result = string.Empty;
    if (array.GetLength(0) < line || array.GetLength(1) < column)
    {
        result = "под такими позициями элемента в массиве не сущетсвует";
        return result;
    }

    {
        result = Convert.ToString(array[line, column]);
        return result;
    }
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



try
{
    Console.Write("Введите номер строки для поиска: ");
    int x = Int32.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца для поиска: ");
    int y = Int32.Parse(Console.ReadLine());
    string result = FindNumber(x, y, array);
    Console.WriteLine($"Результат : {result}");
}
catch
{
    Console.Write("Ошибка: не верно введены данные для поиска.");
}