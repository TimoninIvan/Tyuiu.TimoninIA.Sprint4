using Tyuiu.TimoninIA.Sprint4.Task3.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Тимонин И. А. | ИИПб 24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                                ");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              ");
        Console.WriteLine("* Задание #3                                                               ");
        Console.WriteLine("* Вариант #18                                                              ");
        Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПб 24-1                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         ");
        Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите максимальный      ");
        Console.WriteLine("* элемент в последней строке массива.                                      ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int[,] test = new int[5, 5] {
            { 2, 4, 2, 7, 7 },
            { 4, 7, 9, 9, 7 },
            { 8, 5, 5, 6, 5 },
            { 7, 7, 5, 2, 9 },
            { 9, 3, 7, 9, 8 }
        };
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(test));
    }
}