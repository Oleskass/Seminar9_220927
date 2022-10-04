// =================================================================
// #64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// =================================================================

// запрашивает данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// показывает числа от N до 1 с рекурсией
string LineGenRecDesc(int numN)
{
    if (numN <= 0) return ""; // точка остановки
    string outLine = numN + " " + LineGenRecDesc(numN - 1);
    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLineDesc = LineGenRecDesc(numN);
PrintResult(resultLineDesc);