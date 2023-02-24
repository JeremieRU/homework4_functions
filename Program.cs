int TakeConsoleInt(string str = "Введите число: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

double Pow(double a, double b)
{
    if (b == 0)
    {
        double answ = 1;
        return answ;
    }
    else if (b > 0)
    {
        double answ = a;
        int i = 1;
        while (i < b)
        {
            answ = answ * a;
            i++;
        }
        return answ;
    }
    else
    {
        double answ = a;
        double answ2 = a;
        int i = 1;
        while (i < Math.Abs(b))
        {
            answ2 = answ2 * a;
            i++;
        }
        answ = 1 / answ2;
        return answ;
    }
}

int Summofnumb(int a)
{
    int answ = 0;
    while (a != 0)
    {
        answ = answ + a % 10;
        a = a / 10;
    }
    return answ;
}

int[] CreateArray(int size = 8, int from = 0, int to = 100)
{
    int[] t_array = new int[size];
    for (int i = 0; i < size; i++)
        t_array[i] = new Random().Next(from, to + 1);
    return t_array;
}

void PrintArrayComa(int[] t_array)
{
    for (int i = 0; i < t_array.Length - 1; i++)
        Console.Write($"{t_array[i]}, ");
    Console.Write(t_array[t_array.Length - 1]);
}

void PrintArrayComaBracket(int[] t_array)
{
    Console.Write("[");
    for (int i = 0; i < t_array.Length - 1; i++)
        Console.Write($"{t_array[i]}, ");
    Console.Write(t_array[t_array.Length - 1]);
    Console.Write("]");
}

switch (TakeConsoleInt("Введите номер задачи(25, 27, 29): "))
{
    case 25:
        Console.Write("Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\nНапример:\n3, 5 -> 243\n2, 4 -> 16\n");
        double c = TakeConsoleInt("Введите число A: ");
        double d = TakeConsoleInt("Введите число B (в какую чтепень возводить): ");
        Console.WriteLine($"{c}^{d} -> {Pow(c, d)}");
        break;
    case 27:
        Console.Write("Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\nНапример:\n452 -> 11\n82 -> 10\n9012 -> 12\n");
        int e = TakeConsoleInt();
        Console.WriteLine($"{e} -> {Summofnumb(e)}");
        break;
    case 29:
        Console.Write("Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\nНапример:\n1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]\n6, 1, 33 -> [6, 1, 33]\n");
        int[] array = CreateArray(TakeConsoleInt("Введите размер массива: "), TakeConsoleInt("Введите нижний порог значений элементов массива: "), TakeConsoleInt("Введите верхний порог значений элементов массива: "));
        PrintArrayComa(array);
        Console.Write(" -> ");
        PrintArrayComaBracket(array);
        break;
    default:
        Console.Write("Введён некорректный номер задачи");
        break;
}
